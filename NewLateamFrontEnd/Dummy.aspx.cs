using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewLateamFrontEnd.ServiceReference1;
namespace NewLateamFrontEnd
{
    public partial class Dummy : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add(object sender, EventArgs e)
        {/*
            bool check = link.addHairstyle1(Session["StylistUName"].ToString(), styleName.Value, Convert.ToDouble(price.Value), image.Value);
            if(check==true)
            {
                Response.Redirect("Home.aspx");
            }else
            {
                Response.Redirect("An Error has occured");
            }*/
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {/*
            string show = "";
            Hairstyle1 h = new Hairstyle1();
            dynamic mystyles = link.getHairstyle1(Session["StylistUName"].ToString());
            show += "<section class='ftco-section ftco-team'>";
            show += "<div class='container-fluid px-md-5'>";
            show += "<div class='row justify-content-center pb-3'>";
            show += "<div class='col-md-10 heading-section text-center ftco-animate'>";
            show += "<h2 class='mb-4'>My HairStyles</h2>";
            show += "</div>";
            show += "</div>";
            show += "<div class='row'>";
            show += "<div class='col-md-12 ftco-animate'>";
            show += "<div class='carousel-team owl-carousel'>";
            foreach (Hairstyle1 hairstyle in mystyles)
            {
                show += "<div class='item'>";
                show += "<a href='#' class='team text-center'>";
                show += "<div class='img' style='background-image: url(" + hairstyle.Image + ");'></div>";
                show += "<h2>" + hairstyle.HairstyleName + "</h2>";
                show += "<span class='position'>" + hairstyle.HairstylePrice + "</span>";
                show += "</a>";
                show += "</div>";
            }
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</section>";

            display.InnerHtml = show;
            */
        }
    }
}