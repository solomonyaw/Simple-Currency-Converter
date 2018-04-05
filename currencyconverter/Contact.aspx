<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<!DOCTYPE html>
<html>
    <head>
        <title> Contact Me </title>
        <link href="Converter.css" type="text/css" rel="stylesheet" />
        <style>
            a:hover {
                color:red;
            }
            p.email {
                color:blue;
            }

         p {
    text-align:left;
    }
           
            h1, h2,h3 {
color: #ee3e80;}
     
           
        </style>
            </head>
   
    <body> 
    
       
           
        <form ID="form3" runat="server" method="post"> 
    
        <ul class="menu"><li><a href="Home.aspx">Home</a></li>
            <li><a href="CurrencyConverter.aspx">Currency Converter</a></li>
            <li><a href="Contact.aspx">Contact </a></li>
        </ul>
            <asp:Image src="Images/Solo.jpg" ID="Image1" runat="server" style="margin-left: 349px; margin-right: 220px; margin-top: 0px;" Width="200px" ImageAlign="Middle" Height="245px" />
            <br />
            
           <h3> Contact Me</h3>
            <p class="name">Name :Solomon Yaw Adeklo</p>
            <p class ="email">Email: sadeklo@st.vvu.edu.gh</p>
            <p class="facebook">Facebook: <a href="www.facebook.com/solomon.yaw/">www.facebook.com/solomon.yaw</a></p>
            

           
       
           
          
        </form>
       
    </body>
    
</html>
