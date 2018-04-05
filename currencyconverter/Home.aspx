<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>
<html>
    <head>
        <title> Home </title>
        <link href="Converter.css" type="text/css" rel="stylesheet" />
        <style>
            a:hover {
                color:red;
            }
         p {
    text-align:left;
    }
           
            h1, h2 {
color: #ee3e80;}
     
           
        </style>
            </head>
   
    <body> 
    
       
           
        <form ID="form2" runat="server" method="post"> 
    
        <ul class="menu"><li><a href="Home.aspx">Home</a></li>
            <li><a href="CurrencyConverter.aspx">Currency Converter</a></li>
            <li><a href="Contact.aspx">Contact </a></li>
        </ul>
            <asp:Image src="Images/Cedi.jpg" ID="Image1" runat="server" style="margin-left: 349px; margin-right: 220px; margin-top: 0px;" Width="187px" ImageAlign="Middle" Height="148px" />
            <br />
            
           <h1> About Currency Converter</h1>
            <p> After having an introductory knowledge on how to kick start ASP.net, I decided to build
                a simple web application with C#. This web application is a currency converter.It converts 
                the Ghanaian currency to other world known currencies. I built this system in other to encourage 
                other novice developers out there who have an interest to learn ASP.Net
            </p>
            <h2> Ghana Currency Converter</h2>
            <p>If you are interested in converting Ghana Cedis into other currencies, click here <a href="CurrencyConverter.aspx">Currency Converter</a></p>
            

           
       
           
          
        </form>
       
    </body>
    
</html>
