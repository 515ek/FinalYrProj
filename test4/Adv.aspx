<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adv.aspx.cs" Inherits="test4.Adv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Advertiser</title>
    <link type="text/css" rel="stylesheet" href="Styles/w3.css" />
</head>
<body class="w3-display-topmiddle" style="background-color:azure">
    <form id="form1" runat="server">
        <h1 class="w3-text-deep-orange">
            Register your Advertisement to get started
        </h1>
    <div>
        <asp:Table runat="server" HorizontalAlign="Center" CssClass="w3-table w3-text-shadow-white" >
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Label runat="server" CssClass="w3-animate-input w3-label" Text="Ad Catagory"></asp:Label>
                </asp:TableCell>
                <asp:TableCell CssClass="w3-animate-zoom">
                    <asp:DropDownList runat="server" ID="Adcat" CssClass="w3-select w3-select select:focus">
                        <asp:ListItem Selected="False" Enabled="true" Text="--Select--" />
                        <asp:ListItem Selected="False" Enabled="true" Text="Sports" />
                        <asp:ListItem Selected="False" Enabled="true" Text="Commercial" />
                        <asp:ListItem Selected="False" Enabled="true" Text="Technical" />
                        <asp:ListItem Selected="False" Enabled="true" Text="Stationary" />
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Label runat="server" CssClass="w3-animate-input w3-label" Text="Ad Title"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="Atitle" CssClass="w3-animate-zoom w3-input w3-text-blue" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Label runat="server" CssClass="w3-animate-input w3-label" Text="Ad Description"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="Adesc" CssClass="w3-animate-zoom w3-input w3-text-blue" runat="server" TextMode="MultiLine" MaxLength="100" Rows="5" Columns="20"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Label runat="server" CssClass="w3-animate-input w3-label" Text="Select Slot"></asp:Label>
                </asp:TableCell>
                <asp:TableCell CssClass="w3-animate-zoom">
                    <asp:DropDownList runat="server" AutoPostBack="true" ID="Adslot" CssClass="w3-select w3-select select:focus" >
                        <asp:ListItem>
                            --Select--
                        </asp:ListItem>
                        <asp:ListItem>
                            Slot1:Top-Horizontal Space
                        </asp:ListItem>
                        <asp:ListItem>
                            Slot2:Left-Vertical Space
                        </asp:ListItem>
                        <asp:ListItem>
                            Slot3:Right-Vertical Space
                        </asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Label runat="server" CssClass="w3-animate-input w3-label" Text="Give Priority"></asp:Label>
                </asp:TableCell>
                <asp:TableCell CssClass="w3-animate-zoom">
                    <asp:DropDownList runat="server" AutoPostBack="true" ID="Adprior" CssClass="w3-select w3-select select:focus" >
                        <asp:ListItem>
                            --Select--
                        </asp:ListItem>
                        <asp:ListItem>
                            High
                        </asp:ListItem>
                        <asp:ListItem>
                            Medium
                        </asp:ListItem>
                        <asp:ListItem>
                            Low
                        </asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                     <asp:Label runat="server" CssClass="w3-animate-input w3-label" Text="Image"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:FileUpload runat="server" ID="Adimg" CssClass="w3-btn w3-btn-block" style="background-color:dimgray;" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2">
                     <asp:Button runat="server" ID="Submit" Text="Submit" OnClick="Submit_Click" CssClass="w3-btn-block" style="background-color:#0c9c0b" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2">
                     <div runat="server" id="dbres">

                     </div>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
