using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImgurAPI;
using Microsoft.Extensions.Configuration;
using System.Threading;
using ImgurWinForm.Components;
using ImgurWinForm.Forms.Image.Views;
using ImgurWinForm.Forms.GallerySearch.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using MVPExtension;
using FormComponents.Components.ItemBox.Models;
using HttpRequestModule;


namespace ImgurWinForm
{
    // 2025.03.05 專案功能完結，目前已知無解問題
    // 1. Update image description無效
    // 2. 在album裡面新增image無效
    // 3. 將album發表成gallery無效 (明明有給title卻一直跳出沒有title的error)

    
    
    // 2025.02.17新增
    // 1. 這裡，我的IPresenter根據AView子類別需求功能來擴充，那我的最父類別的AView
    //    也要根據它的子類別需求功能來擴充function給presenter使用嗎？(參考AGalleryAlbumContextView)
    // 2. 圖片上傳API發成功後，無法顯示
    // 3. updateImage的API無效，所以圖片的description無法更新
    // 4. 更新album的title需要發put。並且需要album有被更新過title，才能發表到gallery
    // 5. MVP目前的架構，依賴注入的部分
    //    這樣不行  APictureView, PictureView
    //                           ADeletablePictureView, DeletablePictureView
    //    這樣可以  APictureView, ABasicPictureView, BasicPictureView
    //                           ADeletablePictureView, DeletablePictureView
    //    但感覺前者比較直觀，我只要用繼承來寫我想擴充的東西。
    //    後者則是擴充A功能，結果我要繼承兩次，分別代表沒擴充的類別和有擴充的


    // 2025.02.07新增
    // 1. 圖片渲染不支援.mp4 .gif ...(?)
    // V2. sub comment越多層，會load越來越慢。經查詢不太像是遞迴造成的，可能是async void造成
    // 3. 新送出留言後，按下collapse之後，會看到+0 repiles。按下+0 repiles之後看不到新的留言了。
    //    必須要將視窗關掉重開才看的到新留言 => 定期update、留言完之後update
    // V4. reply要增加圖片模式


    // 2025.01.25新增
    // 1. 除了req和res model之外，是否要再多一個ref model或是init model，
    // 用來初始化元件以及紀錄元件目前的狀態
    // 2. 永遠是先處理UI的排列(Parent和Child的關係，再處理Load，這樣才不會再Load的時候，
    // 不知道Parent是誰，然後不知道width要設定多少

    // 待解問題
    // V1. MVPExtension容器，自動判別是不是Presenter，如果是Presenter的話自動使用CreatePresenter
    // 的方式注入，不需要像現在一樣還要依賴Program.ServiceProvider.CreatePresenter(this)的方式呼叫。
    // 不然綁死Program.ServiceProvider的話，不利於更換Program到其他環境，例如不用Winform改用網頁等等
    // 2. 反寫資料流。也就是按完讚後發API request，UI更新了，Imgur端的資料庫也更新了。
    // 但用來渲染的那包List<GalleryAlbumModel>沒有被更新，所以當換頁再回到同一頁之後，在自動
    // 更新開始前，是看不到按完讚的結果的。
    // 3. ItemBoxView與ItemBoxPresenter的分工。管理lock的流程是否應該被放進presenter？
    // 4. 有些相片跑不出來

    // 代辦事項
    // V1. 將手動註冊的部分變成config
    // V2. 自定義開發模板

    internal class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IConfiguration config = CreateConfig();
            var serviceProvider = CreateServiceProvider(config);
            var form = serviceProvider.GetService<GallerySearchForm>();
            var logger = serviceProvider.GetService<ILogger<Program>>();

            try
            {
                Application.Run(form);
            }
            catch (Exception ex)
            {
                
                JsonConvertException jsonConvertException = ex.InnerException as JsonConvertException;
                string result = jsonConvertException.ToString();
                logger.LogInformation(jsonConvertException.ToString());
                Thread.Sleep(1000);
            }
        }

        private static IConfiguration CreateConfig()
        {
            var config = new ConfigurationBuilder()
                         .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                         .AddJsonFile("appsettings.json", true, true)
                         .Build();
            return config;
        }

        // Using self made container
        private static IServiceProvider CreateServiceProvider(IConfiguration config)
        {
            var serviceCollection =  new IoCContainer.ServiceCollection();
            serviceCollection.AddSingleton<GallerySearchForm>();
            serviceCollection.AddTransient<ImageForm>();
            serviceCollection.AddSingleton<Imgur>(sp => CreateImgur
            (
                sp,
                "https://api.imgur.com/3",
                System.Configuration.ConfigurationManager.AppSettings["token"]
            ));
            //serviceCollection.AddTransient<GalleryItem>();
            serviceCollection.AddLogging(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                loggingBuilder.SetMinimumLevel(LogLevel.Trace);
                loggingBuilder.AddNLog(config);
            });

            serviceCollection.AddSingleton(new UpdateConfig { UpdatePeriodSec = 5 });

            serviceCollection.RegisterAllViewsAndPresenters("../../mvp_config.json");

            return serviceCollection.BuildServiceProvider();
        }

        private static Imgur CreateImgur(IServiceProvider serviceProvider, string baseUrl, string token)
        {
            return new Imgur(serviceProvider.GetService<ILogger<Imgur>>(), serviceProvider, baseUrl, token);
        }
    }
}
