using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Navigation2.UITests
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        static readonly Func<AppQuery, AppQuery> AnasayfaCollectionView = c => 
            c.Marked("AnasatfaCollectionView").Property("ItemSSource", "{Binding Products}");
        static readonly Func<AppQuery, AppQuery> AnasayfaFacebookButon = c => c.Marked("AnasayfaFacebookButon");
        static readonly Func<AppQuery, AppQuery> AnasayfaCollectionViewItem = c =>
            c.Marked("AnasayfaCollectionViewItem");
        static readonly Func<AppQuery, AppQuery> Kablolar = c => c.Marked("Kablolar");


        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
#if DEBUG
            app.Repl();
#endif
            AppResult[] result = app.Query(AnasayfaFacebookButon);
            Assert.IsTrue(result.Any(), "Facebook butonu gözükmüyor");      
        }
    }
}
