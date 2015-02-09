<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CenterInformation.aspx.cs" Inherits="CommunityMedicineSystem.Web.HeadOffice.Setup.CenterInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Center Information</title>
    <link href="../../Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" />
    <link href="../../Content/style.css" rel="stylesheet" />
</head>
<body>
    <nav class="navbar navbar-default">
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="../../Index.aspx">Community Medicine System</a>
            </div>
            <div class="collapse navbar-collapse" id="navbar-collapse">
                <ul class="nav navbar-nav">
                    <li><a href="../../Index.aspx">Home <span class="sr-only">(current)</span></a></li>
                    <li><a href="#">Contact Us</a></li>
                </ul>

                <ul class="nav navbar-nav navbar-right">
                    <li><a href="http://www.facebook.com"><i class="fa fa-facebook-official fa-2x"></i></a></li>
                    <li><a href="http://www.twitter.com"><i class="fa fa-twitter fa-2x"></i></a></li>
                    <li><a href="http://www.youtube.com"><i class="fa fa-youtube fa-2x"></i></a></li>
                    <li><a href="../../Login/Login.aspx">Centers</a></li>
                    <li class="active"><a href="../HeadOfficeActivity.aspx">Head Office</a></li>
                    <%--<li>
                        <button type="button" runat="server" class="btn btn-default navbar-btn">Log out</button></li>--%>
                </ul>
            </div>
        </div>
    </nav>
    <form id="form1" class="form-horizontal" runat="server">
        <div class="page-header">
            <h1>Center Creation Information</h1>
        </div>
        <div class="form-group">
            <div class="col-sm-12">
                <div class="alert alert-success" role="alert">
                    <p>Congratulation!! New center has been created successfully.</p>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-6">
                <table class="table table-bordered">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text=" Name"></asp:Label></td>
                        <td>
                            <asp:Label ID="nameLabel" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Code"></asp:Label></td>
                        <td>
                            <asp:Label ID="codeLabel" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label></td>
                        <td>
                            <asp:Label ID="passwordLabel" runat="server" Text=""></asp:Label></td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
    <script src="../../Scripts/bootstrap.js"></script>
    <script src="../../Scripts/jquery-2.1.3.js"></script>
    <script src="../../Scripts/jquery.validate.js"></script>
    <script src="../../Scripts/jquery.validate.min.js"></script>
</body>
</html>
