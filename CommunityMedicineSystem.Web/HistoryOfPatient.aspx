<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HistoryOfPatient.aspx.cs" Inherits="CommunityMedicineSystem.Web.HistoryOfPatient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>History Of Patient</title>
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="datepicker/css/datepicker.css" rel="stylesheet" />
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" />
    <link href="Content/style.css" rel="stylesheet" />
</head>
<body>
    <nav class="navbar navbar-default navbar-fixed-top">
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="Index.aspx">Community Medicine System</a>
            </div>
            <div class="collapse navbar-collapse" id="navbar-collapse">
                <ul class="nav navbar-nav">
                    <li><a href="Index.aspx">Home <span class="sr-only">(current)</span></a></li>
                    <li><a href="#">Contact Us</a></li>
                </ul>

                <ul class="nav navbar-nav navbar-right">
                    <li><a href="http://www.facebook.com"><i class="fa fa-facebook-official fa-2x"></i></a></li>
                    <li><a href="http://www.twitter.com"><i class="fa fa-twitter fa-2x"></i></a></li>
                    <li><a href="http://www.youtube.com"><i class="fa fa-youtube fa-2x"></i></a></li>
                    <li><a href="Login/Login.aspx">Centers</a></li>
                    <li><a href="HeadOffice/HeadOfficeActivity.aspx">Head Office</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <form id="form1" class="form-horizontal" runat="server">
        <div class="page-header" style="margin-top: 100px;">
        <div class="form-group">
            <h1 style="margin-left: -200px;">All Histories Of Patient</h1>
        </div>
    </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Voter Id</label>
            <div class="col-sm-6">
                <asp:TextBox ID="voterIdTextBox" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-4">
                <asp:Button ID="showButton" runat="server" Text="Show" CssClass="btn btn-success" OnClick="showButton_Click" />
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Address</label>
            <div class="col-sm-6">
                <asp:TextBox ID="addressTextBox" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Name</label>
            <div class="col-sm-6">
                <asp:TextBox ID="nameTextBox" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-8">
                <asp:GridView ID="patientHistoryGridView" CssClass="table table-bordered" runat="server" AutoGenerateColumns="True">
                </asp:GridView>
            </div>
        </div>
        <hr/>
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-4">
                <asp:Button ID="pdfButton" CssClass="btn btn-default btn-lg btn-block" runat="server" Text="Show All in Print/Pdf Format" OnClick="pdfButton_Click" />
            </div>
        </div>
        
    </form>
</body>
</html>
