<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Response.aspx.cs" Inherits="test4.Response" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
        <link type="text/css" rel="stylesheet" href="Styles/S1.css" />
        <link type="text/css" rel="stylesheet" href="Styles/w3.css" />
    <style type="text/css">
        #body {
            left: 270px;
            height: 565px;
        }
    </style>
</head>
<body class="w3-display-topmiddle" style="background-color:azure">
    <form id="form1" runat="server">
    <div >
    <asp:ScriptManager ID="script1" runat="server" >

    </asp:ScriptManager>

        <div runat="server"  id="adtop" >
            <asp:UpdatePanel ID="upt1" runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t3" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upt2" runat="server" >
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t3" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upt3" runat="server" >
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t3" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upt4" runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t3" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upt8" runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t3" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upt5" runat="server" >
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t3" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upt6" runat="server" >
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t3" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upt7" runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t3" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
        
        <div runat="server" id="adleft" >
            <asp:UpdatePanel ID="upl1" runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t2" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upl2" runat="server" >
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t2" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upl3" runat="server" >
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t2" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upl4" runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t2" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upl8" runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t2" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upl5" runat="server" >
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t2" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upl6" runat="server" >
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t2" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upl7" runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t2" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
        
        <div runat="server" id="adright" style="">
           <asp:UpdatePanel ID="upr1" runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t1" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upr2" runat="server" >
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t1" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upr3" runat="server" >
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t1" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdatePanel ID="upr4" runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="t1" EventName="Tick" />
                </Triggers>
                <ContentTemplate>

                </ContentTemplate>
            </asp:UpdatePanel>
            
        </div>

        <div id="body" style="position: absolute; top: 169px; right: 284px">
           <iframe src="http://localhost/Trans/" style="position: absolute; top: 5px; left: 4px; height: 685px; width: 735px; margin-left: 0px;"></iframe>

        </div>

        <asp:Timer ID="t2" runat="server" Interval="10000" OnTick="t2_Tick" />
        <asp:Timer ID="t1" runat="server" Interval="5000" OnTick="t1_Tick" />
        <asp:Timer ID="t3" runat="server" Interval="15000" OnTick="t3_Tick" />
    </div>
    </form>
</body>
</html>
