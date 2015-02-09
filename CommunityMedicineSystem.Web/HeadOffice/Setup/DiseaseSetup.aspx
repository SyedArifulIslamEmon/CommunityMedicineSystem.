<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiseaseSetup.aspx.cs" Inherits="CommunityMedicineSystem.Web.HeadOffice.Setup.DiseaseSetup" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Disease Setup</title>
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
    <div class="page-header">
        <div class="form-group">
            <h1 style="margin-left: -200px;">Basic Disease Setup</h1>
        </div>
    </div>
    <div class="container content_top">
        <form class="form-horizontal" runat="server" id="medicineSetupForm">
            <div class="form-group">
                <label class="col-sm-2 control-label"><span style="margin-right: 5px;"><i class="fa fa-medkit"></i></span>Name</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="nameTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Description</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="descriptionTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Treatement Procedure</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="treatementProcedureTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Prefered Drugs</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="preferedDrugsTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                    <asp:Button ID="saveButton" runat="server" CssClass="btn btn-success" Text="Save" OnClick="saveButton_Click" />
                </div>
            </div>
            <div class="alert alert-success">
                <p><asp:Label ID="messageLabel" runat="server" Text=""></asp:Label></p>
            </div>
        </form>
    </div>
    <script src="../../Scripts/bootstrap.js"></script>
    <script src="../../Scripts/jquery-2.1.3.js"></script>
    <script src="../../Scripts/jquery.validate.js"></script>
    <script src="../../Scripts/jquery.validate.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#medicineSetupForm").validate({
                rules: {
                    nameTextBox: "required",
                    descriptionTextBox: {
                        required: true
                    },
                    treatementProcedureTextBox: {
                        required: true
                    },
                    preferedDrugsTextBox: {
                        required: true
                    }
                },
                messages: {
                    nameTextBox: "please enter disease's name",
                    descriptionTextBox: {
                        required: "enter disease's short description"
                    },
                    treatementProcedureTextBox: {
                        required: "enter treatement procedure of the disease."
                    },
                    preferedDrugsTextBox: {
                        required: "enter the drugs prefered for the disease"
                    }
                }
            });
        });
    </script>
</body>

</html>
