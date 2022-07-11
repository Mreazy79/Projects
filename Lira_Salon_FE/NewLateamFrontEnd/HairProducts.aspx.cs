using System;
namespace NewLateamFrontEnd
{
    public partial class HairProducts : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            string show = "";
            dynamic products = link.getProducts();
            show += "<section class='ftco-section ftco-team'>";
            show += "<div class='container-fluid px-md-5'>";
            show += "<div class='row justify-content-center pb-3'>";
            show += "<div class='col-md-10 heading-section text-center ftco-animate'>";
            show += "<h2 class='mb-4'>Hair Products</h2>";
            show += "</div>";
            show += "</div>";
            show += "<div class='row'>";
            show += "<div class='col-md-12 ftco-animate'>";
            show += "<div class='carousel-team owl-carousel'>";
            foreach (Product p in products)
            {
                show += "<div class='item'>";
                show += "<a href='singleProduct.aspx?hairStyleID=" + p.Id + "' class='team text-center'>";
                show += "<div class='img' style='background-image: url(" + p.ProductImage + ");'></div>";
                show += "<h2>" + p.ProductName + "</h2>";
                show += "<span class='position'>" + "R" + p.ProductPrice + "</span>";
                show += " <asp:Button ID=Button1' runat='server' Text='Yes' />";
                show += "</a>";
                show += "</br>";

                show += "</div>";
            }
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</section>";

            showHairstyles.InnerHtml = show;
        }
        public void Js()
        {
        }
    }
}
