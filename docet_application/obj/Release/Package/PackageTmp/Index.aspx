<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="docet_application.WebForm1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Docet File</title>
    <link href="css/Style.css" rel="stylesheet" />
    <script type="text/javascript">
        function validatePolicy() {
            var policyNumber = document.getElementById('<%= Text1.ClientID %>').value;
            if (policyNumber.match(/[0-9]/g) && policyNumber.includes("-")) {
                if (policyNumber.length == 11 || policyNumber.length == 13) {
                    return true;
                } else {
                    alert("Policy Number Error. Please Check Policy Number Length.");
                    return false;
                }
            }
            else {
                alert("Invalid Policy Number! Please Input Currect Policy Number.");
                return false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <asp:Image ID="imglogo" Class="logo" runat="server" ImageUrl="~/img/RliBanner.png" />
            <div class="item">
                <h1>Docet File </h1>
                <div class="dropdown">
                    <select id="select_project" runat="server" class="custom-select">
                        <option value="" selected>Select Project</option>
                        <option value="Ekok">Ekok Bima</option>
                        <option value="Islami">Islami Bima</option>
                        <option value="Samajic">Samajic Bima</option>
                        <option value="Khudro">Khudro Bima</option>
                        <option value="Soria">Soria DPS Bima</option>
                        <option value="Rupali">Rupali Sonchoy Bima</option>
                        <option value="Alamanat">Al-Amanat Bima</option>
                    </select>
                </div>
                <div class="search-container">
                    <label for="text">Policy No:</label>
                    <input type="text" id="Text1" runat="server" class="policy-input" placeholder="Enter Policy Number" onblur="validatePolicy()">
                </div>
                 <asp:Button ID="Policy_Search" Class="search-button" runat="server" Text="Search" Width="100px" Height="25px" OnClick="Policy_Search_Click" />
            </div>
        </div>
        <section class="containar">
            <div class="box-2">
                <div id="pdfimg">
                    <iframe runat="server" id="iframepdf" height="590px" width="100%" src=""></iframe>
                </div>
            </div>
        </section>
        <div class="footer">
            <footer>
                <h5>&copy; Developed by Md. Hafiz</h5>
            </footer>
        </div>
    </form>
</body>
</html>
