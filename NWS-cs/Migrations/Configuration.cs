namespace NWS_cs.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<NWS_cs.NwsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NWS_cs.NwsContext context)
        {

            var ads = new List<Advertisement> {
                new Advertisement {
                    id = 1,
                    link = "Content/Images/ads/ad_image1.png"},
                new Advertisement {
                    id = 2,
                    link = "Content/Images/ads/ad_image2.jpg"}
            };
            ads.ForEach(s => context.Advertisements.AddOrUpdate(s));
            context.SaveChanges();


            var archives = new List<Archive> {
                new Archive {
                    id = 1,
                    title = "Summer 2015 newsletter",
                    link = "Content/Archives/DPNA_Newsletter_Summer_2015.pdf"},
                new Archive {
                    id = 2,
                    title = "Fall 2015 newsletter",
                    link = "Content/Archives/DPNA_Newsletter_Fall_2015.pdf"},
                new Archive {
                    id = 3,
                    title = "Winter 2015 newsletter",
                    link = "Content/Archives/DPNA_Newsletter_Winter_2015.pdf"},
                new Archive {
                    id = 4,
                    title = "Spring 2016 newsletter",
                    link = "Content/Archives/DPNA_Newsletter_Spring_2016.pdf"}
            };
            archives.ForEach(s => context.Archives.AddOrUpdate(s));
            context.SaveChanges();


            var articles = new List<Article> {
                new Article {
                    id = 1,
                    uuid = "4a60c1a5-036f-4ea9-b94c-4d72be6d3aa2",
                    hfso = true,
                    title = "People Article",
                    image = "Content/Images/articles/people1.jpg",
                    text = "People article lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec elit libero, tincidunt sit amet placerat non, finibus vitae orci. Aliquam felis arcu, mattis in volutpat sit amet, volutpat a diam. Pellentesque pharetra nisl luctus purus venenatis tempor ut vitae magna. Donec ac tellus libero. Morbi ultricies arcu nec pretium maximus. Vivamus congue dolor sed libero lobortis, in ullamcorper elit vestibulum. Aenean pellentesque est non elementum vehicula. Vivamus ac lectus dolor. Integer risus arcu, sollicitudin sed vulputate nec, molestie eu odio. Quisque quam diam, viverra non leo eu, mattis semper ante. Duis sed lectus fermentum, dignissim turpis ut, feugiat elit. Vivamus sit amet neque risus."},
                new Article {
                    id = 2,
                    uuid = "411a0890-723c-4fb0-b574-82aef5e1b64a",
                    hfso = true,
                    title = "Nature Article",
                    image = "Content/Images/articles/nature1.jpg",
                    text = "Nature article phasellus commodo tortor a imperdiet volutpat. Nam dapibus sodales velit eget accumsan. Etiam accumsan rhoncus aliquet. Integer quis auctor mi, in condimentum eros. In eleifend, lacus vel suscipit facilisis, felis libero consequat mi, commodo porta tellus mi eu neque. Fusce in elit sed sapien pulvinar dictum. Pellentesque nec aliquam diam, eget suscipit leo. Curabitur eleifend augue vitae libero tincidunt sagittis. Pellentesque vestibulum nec sapien quis rutrum. Mauris erat ex, ullamcorper a tortor vitae, iaculis tincidunt mauris. Ut in diam orci. In et neque imperdiet, gravida odio in, dictum odio."},
                new Article {
                    id = 3,
                    uuid = "66f30199-86f1-483c-b8fd-d1bf057ac6b2",
                    hfso = false,
                    title = "Food Article",
                    image = "Content/Images/articles/food1.jpg",
                    text = "Food article vivamus sed quam id ligula dictum posuere sed eget turpis. Suspendisse a metus at purus scelerisque condimentum eu vitae urna. Etiam sit amet viverra quam. Sed sagittis, dolor in cursus placerat, ex lacus faucibus erat, at imperdiet eros orci ac arcu. Pellentesque velit libero, bibendum ut dictum ac, pellentesque quis quam. Nam feugiat vel risus et fringilla. Vestibulum commodo arcu sem. Vivamus vel nisi lorem. Donec in cursus lorem, pellentesque porttitor dui. Cras sollicitudin metus nec euismod tempor. Pellentesque maximus, dui sit amet rutrum sagittis, mi sem maximus dui, eget consequat augue diam et nisi. Mauris accumsan libero in velit vestibulum, non scelerisque diam tristique. Morbi id congue mi, sit amet ullamcorper est."},
                new Article {
                    id = 4,
                    uuid = "11084cf1-5abf-49e7-87f9-2c4a5d6f04ff",
                    hfso = true,
                    title = "British Flag",
                    image = "Content/Images/articles/british_flag.png",
                    text = "British flag duis vitae interdum ex, in suscipit lacus. Sed mollis est scelerisque purus dapibus aliquam. Donec a elit ut urna pulvinar sollicitudin. Fusce et purus eget nisi vestibulum laoreet. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Phasellus arcu mi, condimentum id lacinia sollicitudin, maximus ac lacus. Vestibulum vehicula vestibulum magna, tempor pretium sapien sagittis sit amet. Fusce sollicitudin feugiat efficitur. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin bibendum nisi ac nisi faucibus, fringilla elementum libero auctor. Donec ornare, velit nec malesuada tincidunt, est enim lobortis felis, in posuere lorem felis in leo. Praesent porttitor, felis eu ultrices blandit, est urna sodales sem, quis aliquam sapien felis ac lacus. Mauris sed condimentum ante, ac sollicitudin justo."},
                new Article {
                    id = 5,
                    uuid = "d6303779-dfd9-4e09-bd0f-37502265cafd",
                    hfso = false,
                    title = "American Flag",
                    image = "Content/Images/articles/american_flag.png",
                    text = "American flag vestibulum sodales maximus tincidunt. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed sapien purus, aliquet iaculis augue congue, ornare mattis neque. Phasellus sit amet metus consequat, vulputate tortor nec, pretium mauris. In est nisi, dictum sit amet nunc vitae, egestas finibus dui. Curabitur dapibus, elit id interdum tincidunt, velit lacus gravida massa, et vestibulum arcu dui vel tortor. Quisque ornare cursus feugiat. Curabitur felis nunc, pellentesque ut augue eget, vestibulum commodo nisl. Cras imperdiet, lorem sed placerat eleifend, orci ipsum volutpat arcu, tristique dignissim turpis arcu ut turpis. Maecenas fermentum eros quis nulla tempor, sit amet scelerisque augue auctor. In posuere arcu at ante fringilla, imperdiet vehicula augue consectetur. Nam tincidunt volutpat lectus, blandit sagittis nunc mattis vitae. Aliquam non est justo. Vivamus interdum magna quis porttitor varius. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae."}
            };
            articles.ForEach(s => context.Articles.AddOrUpdate(s));
            context.SaveChanges();


            var feature = new List<Feature> {
                new Feature {
                    id = 1,
                    article = "This is feature text. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla sit amet ipsum id velit dapibus maximus. Maecenas non felis interdum, efficitur justo ut, maximus felis. \r\n\r\nUt mauris lorem, gravida vel metus et, pulvinar malesuada erat. Sed sem ex, ullamcorper id ornare eu, imperdiet faucibus nunc. Sed nec lobortis nunc, eu porta orci. \r\n\r\nDonec eget dignissim odio, ut sagittis neque. Pellentesque pharetra volutpat maximus. ",
                    image1 = "Content/Images/feature/construction1.jpg",
                    image2 = "Content/Images/feature/construction2.jpg",
                    image3 = "Content/Images/feature/construction3.jpg",
                    title = "New Construction in Deer Park"}
            };
            feature.ForEach(s => context.Features.AddOrUpdate(s));
            context.SaveChanges();


            var officers = new List<Officer> {
                new Officer {
                    id = 1,
                    name = "Stephen Dyer",
                    email = "stephen.dyer@dpnatest.com",
                    description = "co-President",
                    photo = "Content/Images/officers/Stephen_Dyer.jpg"},
                new Officer {
                    id = 2,
                    name = "Anthony Short",
                    email = "anthony.short@dpnatest.com",
                    description = "co-President",
                    photo = "Content/Images/officers/Anthony_Short.jpg"},
                new Officer {
                    id = 3,
                    name = "Victoria Coleman",
                    email = "victoria.coleman@dpnatest.com",
                    description = "Treasurer",
                    photo = "Content/Images/officers/Victoria_Coleman.jpg"},
                new Officer {
                    id = 4,
                    name = "Luke Vaughan",
                    email = "luke.vaughan@dpnatest.com",
                    description = "Secretary",
                    photo = "Content/Images/officers/Luke_Vaughan.jpg"},
                new Officer {
                    id = 5,
                    name = "Gabrielle Metcalfe",
                    email = "gabrielle.metcalfe@dpnatest.com",
                    description = "Board Member",
                    photo = "Content/Images/officers/Gabrielle_Metcalf.jpg"},
                new Officer {
                    id = 6,
                    name = "Penelope Mitchell",
                    email = "penelope.mitchell@dpnatest.com",
                    description = "Board Member",
                    photo = "Content/Images/officers/Penelope_Mitchell.jpg"},
                new Officer {
                    id = 7,
                    name = "David Ferguson",
                    email = "david.ferguson@dpnatest.com",
                    description = "Board Member",
                    photo = "Content/Images/officers/David_Ferguson.jpg"},
                new Officer {
                    id = 8,
                    name = "Eric Kerr",
                    email = "eric.kerr@dpnatest.com",
                    description = "Board Member",
                    photo = "Content/Images/officers/Eric_Kerr.jpg"},
                new Officer {
                    id = 9,
                    name = "Dorothy Martin",
                    email = "dorothy.martin@dpnatest.com",
                    description = "Board Member",
                    photo = "Content/Images/officers/Dorothy_Martin.jpg"},
                new Officer {
                    id = 10,
                    name = "Carolyn Underwood",
                    email = "carolyn.underwood@dpnatest.com",
                    description = "Board Member",
                    photo = "Content/Images/officers/Carolyn_Underwood.jpg"}
            };
            officers.ForEach(s => context.Officers.AddOrUpdate(s));
            context.SaveChanges();


            var services = new List<Service> {
                new Service {id = 1, text = "Emergencies: 911"},
                new Service {id = 2, text = "City Call (non-emergency): 311 or 555-2221"},
                new Service {id = 3, text = "Police, DP district (non-emergency): 555-1212"},
                new Service {id = 4, text = "Metro Council Member's Office: 555-2211"},
                new Service {id = 5, text = "Mayor's Office: 555-1122"},
                new Service {id = 6, text = "School Board: 555-1112"}
            };
            services.ForEach(s => context.Services.AddOrUpdate(s));
            context.SaveChanges();


            var videos = new List<Video> {
                new Video {
                    id = 1,
                    site = "onsite",
                    type = "video/webm",
                    title = "Natural Gas",
                    description = "Large quantities of natural gas discovered in Deer Park neighborhood!",
                    link = "Content/Videos/Natural_Gas_video.webm"},
                new Video {
                    id = 2,
                    site = "youtube",
                    type = "",
                    title = "Pinback: A Request",
                    description = "From the album 'Information Received'.",
                    link = "https://www.youtube.com/embed/MaHrMR7JRS8"},
                new Video {
                    id = 3,
                    site = "",
                    type = "",
                    title = "No video",
                    description = "Sorry, there is no video available.",
                    link = "Content/Images/no_cat.jpg"},
                new Video {
                    id = 4,
                    site = "youtube",
                    type = "",
                    title = "Dave's World: He Gooched His Bass Guitar",
                    description = "Dave fixes a bass guitar and enjoys a beer.",
                    link = "https://www.youtube.com/embed/EZ10jbzcD18"},
                new Video {
                    id = 5,
                    site = "youtube",
                    type = "",
                    title = "You Only Live Once (Cover)",
                    description = "Five dudes, who look remarkably alike, cover The Strokes.",
                    link = "https://www.youtube.com/embed/GLf3nrZXZT8"}
            };
            videos.ForEach(s => context.Videos.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}

