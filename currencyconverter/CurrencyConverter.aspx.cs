using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CurrencyConverter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack==false)
        {
            // adding Itmes to the combo box
            Currency.Items.Add(new ListItem("American Dollar","4.249"));
            Currency.Items.Add(new ListItem("Australian Dollar","3.181"));
            Currency.Items.Add(new ListItem("Indian Rupee","0.0623"));
            Currency.Items.Add(new ListItem("Swiss Franc","4.204"));
            Currency.Items.Add(new ListItem("Brittish Pound","5.168"));
            Currency.Items.Add(new ListItem("Euro","4.51"));
            Currency.Items.Add(new ListItem("Chinese Yuan","0.6153"));
            Currency.Items.Add(new ListItem("Russian Ruble","0.0716"));
            Currency.Items.Add(new ListItem("Japanese Yen","0.0369"));
            Currency.Items.Add(new ListItem("Canadian Dollar","3.228"));

            //Add Ghana Flag
            Image image = new Image();
            image.ImageUrl = "Images/Gh.png";
            image.Visible = true;
            this.Controls.Add(image);

            Graph.Visible = false;

            Result.InnerText = "Convert Ghana Cedis to any other Currency";
                    
        }

    }
    protected void ShowGraph_ServerClick(object sender, EventArgs e)
    {
        Graph.Src = "Pic"+Currency.SelectedIndex.ToString() + ".png";
        Graph.Visible = true;
     
    }
    protected void Convert_ServerClick(object sender, EventArgs e)
    {
        decimal oldAmount;
        bool Success = Decimal.TryParse(US.Value, out oldAmount);
        if ((oldAmount<=0) || (Success==false))
        {
            Result.Style["color"]= "red";
            Result.InnerText ="Specify a positive integer";
        }
        else
        {
            if(Success)
            {
                if (Currency.SelectedIndex == 0)
                {
                    
                    //Convert Currency to Us dollars
                    ListItem item = Currency.Items[Currency.SelectedIndex];
                    decimal newAmount = oldAmount * Decimal.Parse(item.Value);
                    Result.InnerText = oldAmount.ToString() + "Ghana Cedis = " ;
                    Result.InnerText += newAmount.ToString() + " "+item.Text;

                    //add American Flag
                    Image image = new Image();
                    image.ImageUrl = "Images/US.png";
                    image.Visible = true;
                    this.Controls.Add(image);             
                    
                    
                    

                }
                if (Currency.SelectedIndex == 1)
                {
                    ListItem item = Currency.Items[Currency.SelectedIndex];
                    decimal newAmount = oldAmount * Decimal.Parse(item.Value);
                    Result.InnerText = oldAmount.ToString() + " Ghana Cedis = ";
                    Result.InnerText += newAmount.ToString() + " " + item.Text;

                    //add Australian Flag
                    Image image = new Image();
                    image.ImageUrl = "Images/Australia.png";
                    image.Visible = true;
                    this.Controls.Add(image);             
                    

                }
                if (Currency.SelectedIndex == 2)
                {
                    ListItem item = Currency.Items[Currency.SelectedIndex];
                    decimal newAmount = oldAmount * Decimal.Parse(item.Value);
                    Result.InnerText = oldAmount.ToString() + " Ghana Cedis = ";
                    Result.InnerText += newAmount.ToString() + " " + item.Text;

                    //add Indian Flag
                    Image image = new Image();
                    image.ImageUrl = "Images/India.png";
                    image.Visible = true;
                    this.Controls.Add(image);  

                }
                 if (Currency.SelectedIndex == 3)
                {
                    ListItem item = Currency.Items[Currency.SelectedIndex];
                    decimal newAmount = oldAmount * Decimal.Parse(item.Value);
                    Result.InnerText = oldAmount.ToString() + " Ghana Cedis = ";
                    Result.InnerText += newAmount.ToString() + " " + item.Text;

                    //add Swiss Flag
                    Image image = new Image();
                    image.ImageUrl = "Images/Swiss.png";
                    image.Visible = true;
                    this.Controls.Add(image);  



                }
                 if (Currency.SelectedIndex == 4)
                {
                    ListItem item = Currency.Items[Currency.SelectedIndex];
                    decimal newAmount = oldAmount * Decimal.Parse(item.Value);
                    Result.InnerText = oldAmount.ToString() + " Ghana Cedis = ";
                    Result.InnerText += newAmount.ToString() + " " + item.Text;

                    //add Brittish Flag
                    Image image = new Image();
                    image.ImageUrl = "Images/UK.png";
                    image.Visible = true;
                    this.Controls.Add(image);  



                }
                 if (Currency.SelectedIndex == 5)
                {
                    ListItem item = Currency.Items[Currency.SelectedIndex];
                    decimal newAmount = oldAmount * Decimal.Parse(item.Value);
                    Result.InnerText = oldAmount.ToString() + " Ghana Cedis = ";
                    Result.InnerText += newAmount.ToString() + " " + item.Text;

                    //add European Flag
                    Image image = new Image();
                    image.ImageUrl = "Images/Euro.png";
                    image.Visible = true;
                    this.Controls.Add(image);  



                }
                 if (Currency.SelectedIndex == 6)
                {
                    ListItem item = Currency.Items[Currency.SelectedIndex];
                    decimal newAmount = oldAmount * Decimal.Parse(item.Value);
                    Result.InnerText = oldAmount.ToString() + " Ghana Cedis = ";
                    Result.InnerText += newAmount.ToString() + " " + item.Text;

                    //add Chinese Flag
                    Image image = new Image();
                    image.ImageUrl = "Images/China.png";
                    image.Visible = true;
                    this.Controls.Add(image);

                }
                 if (Currency.SelectedIndex == 7)
                {
                    ListItem item = Currency.Items[Currency.SelectedIndex];
                    decimal newAmount = oldAmount * Decimal.Parse(item.Value);
                    Result.InnerText = oldAmount.ToString() + " Ghana Cedis = ";
                    Result.InnerText += newAmount.ToString() + " " + item.Text;

                    //add Russia Flag
                    Image image = new Image();
                    image.ImageUrl = "Images/Russia.png";
                    image.Visible = true;
                    this.Controls.Add(image);


                }
                 if (Currency.SelectedIndex == 8)
                {
                    ListItem item = Currency.Items[Currency.SelectedIndex];
                    decimal newAmount = oldAmount * Decimal.Parse(item.Value);
                    Result.InnerText = oldAmount.ToString() + " Ghana Cedis = ";
                    Result.InnerText += newAmount.ToString() + " " + item.Text;

                    //add Japanese Flag
                    Image image = new Image();
                    image.ImageUrl = "Images/Japan.png";
                    image.Visible = true;
                    this.Controls.Add(image);
                   
                }
                 if (Currency.SelectedIndex == 9)
                {
                    ListItem item = Currency.Items[Currency.SelectedIndex];
                    decimal newAmount = oldAmount * Decimal.Parse(item.Value);
                    Result.InnerText = oldAmount.ToString() + " Ghana Cedis = ";
                    Result.InnerText += newAmount.ToString() + " " + item.Text;

                    //add Canada Flag
                    Image image = new Image();
                    image.ImageUrl = "Images/Canada.png";
                    image.Visible = true;
                    this.Controls.Add(image);

                }
            }
            else
            {
                Result.InnerText = "The number you typed is not in the correct format."
                    +" Use only numbers";
                //Add Ghana Flag
                Image image = new Image();
                image.ImageUrl = "Images/Gh.png";
                image.Visible = true;
                this.Controls.Add(image);
                    
            }
        }
            
    }
}