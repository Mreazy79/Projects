using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewLateamFrontEnd.ServiceReference1;
namespace NewLateamFrontEnd
{
    
    public partial class MyStylist : System.Web.UI.Page
    {
        Service2Client link = new Service2Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string show = "";
            Stylist s = new Stylist();
           dynamic styles = link.getStylists(s);
            show += "<section class='ftco-section ftco-team'>";
            show += "<div class='container-fluid px-md-5'>";
            show += "<div class='row justify-content-center pb-3'>";
            show += "<div class='col-md-10 heading-section text-center ftco-animate'>";
            show += "<h2 class='mb-4'>Stylists</h2>";
            show += "</div>";
            show += "</div>";
            show += "<div class='row'>";
            show += "<div class='col-md-12 ftco-animate'>";
            show += "<div class='carousel-team owl-carousel'>";
            foreach (Stylist style in styles)
            {
                show += "<div class='item'>";  
                //show += "<a href='#' class='team text-center'>";
                show += "<a href='Stylists.aspx?StylistID=" +style.Id + "' class='team text-center'>";
               // Display += "<a href='AboutPet.aspx?PetId=" + k.ToString() + "'>";
                show += "<div class='img' style='background-image: url(" + style.Image + ");'></div>";
                show += "<h2>" + style.FirstName + "</h2>";
                show += "</br>";
                show += "<span class='position'>" + style.PhoneNumber + "</span>";
                show += "</br>";
                show += "<span class='position'>" + style.SalonAddress + "</span>";
                show += "</br>";
                show += "<span class='position'>" + style.SalonName + "</span>";
                Session["Email"] = style.Email;
                Session["SalonName"] = style.SalonName;
                show += "</a>";
                show += "</div>";
            }
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</div>";
            show += "</section>";

            showImage.InnerHtml = show;
        }
        public void searchHairstyle(object sender, EventArgs e)
        {/*
            showImage.Visible = false;
            var styles = link.searchSalon(search.Value);
            if (styles != null)
            {
                string show = "";
                show += "<section class='ftco-section ftco-team'>";
                show += "<div class='container-fluid px-md-5'>";
                show += "<div class='row justify-content-center pb-3'>";
                show += "<div class='col-md-10 heading-section text-center ftco-animate'>";
                show += "<h2 class='mb-4'>Hair Styles</h2>";
                show += "</div>";
                show += "</div>";
                show += "<div class='row'>";
                show += "<div class='col-md-12 ftco-animate'>";
                show += "<div class='carousel-team owl-carousel'>";
                
                    show += "<div class='item'>";
                    show += "<a href='Booking.aspx?hairStyleID" + styles.Id + "' class='team text-center'>";
                    show += "<div class='img' style='background-image: url(" + styles.SalonName + ");'></div>";
                    show += "<h2>" + styles.SalonName + "</h2>";
                    show += "</br>";
                    show += "<h2>" + styles.SalonAddress + "</h2>";
                    show += "</br>";
                    show += "<span class='position'>" + styles.PhoneNumber + "</span>";
                    
                    show += "</a>";
                    show += "</br>";

                    show += "</div>";
                
                show += "</div>";
                show += "</div>";
                show += "</div>";
                show += "</div>";
                show += "</div>";
                show += "</section>";
                showImage.Visible = true;
                showImage.InnerHtml = show;
            }
            else
            {
                showImage.Visible = true;
                showImage.InnerText = " "+ " "+"      Salon does not Exist!";
            }
        */}
    }
}