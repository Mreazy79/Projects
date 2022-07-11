using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewLateamFrontEnd.ServiceReference1;
namespace NewLateamFrontEnd
{
    public partial class Home : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            stylistReg.Visible = false;
            first.Visible = true;
            second.Visible = false;
            if (Session["1"] != null)
            {
                stylistReg.Visible = true;
                second.Visible = true;
                first.Visible = false;
            } else if (Session["2"] != null)
            {
                second.Visible = true;
                stylistReg.Visible = false;
                first.Visible = false;


            } else if (Session["3"] != null)
            {
                second.Visible = true;
                first.Visible = false;
            }
            else if(Session["UserName"]==null)
            {
                stylistReg.Visible = false;
            }
            /*
            string show = "";
            Stylist h = new Stylist();
            dynamic mystyles = link.getHairstyle1(1);
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
            foreach (Stylist style in mystyles)
            {
                show += "<div class='item'>";
                show += "<a href='#' class='team text-center'>";
                show += "<div class='img' style='background-image: url(" + style.Image + ");'></div>";
                show += "<h2>" + style.FirstName + "</h2>";
                show += "<span class='position'>" + style.PhoneNumber + "</span>";
                show += "</a>";
                show += "</div>";
                Session["SalonName"] = style.SalonName;
            }
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</section>";

            showImage.InnerHtml = show;

            */


        }
        protected void stylistReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("BecomeStylist.aspx");
        }
        protected void book_Click(object sender, EventArgs e)
        {
            Response.Redirect("exe");
        }
    }
}