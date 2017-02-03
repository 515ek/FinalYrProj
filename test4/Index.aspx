<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="test4.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
    <link type="text/css" rel="stylesheet" href="Styles/w3.css" />
</head>
<body class="w3-display-middle" style="background-color:azure">
    <form id="form1" runat="server">
        <h1 class="w3-text-deep-orange">
            Welcome to the Online Advertising 
        </h1>
    <div runat="server" >
    
        <asp:Button ID="Adv" runat="server"  Width="250px" Text="Advertiser" OnClick="Adv_Click" CssClass="w3-btn" style="background-color:#0c9c0b" />
        <br /><br />
        <asp:Button ID="Cust" runat="server" Width="250px" Text="Customer" OnClick="Cust_Click" CssClass="w3-btn"  style="background-color:#0c9c0b" />
        
    
    </div>
    </form>
</body>
</html>
