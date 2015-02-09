<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HeadOfficeActivity.aspx.cs" Inherits="CommunityMedicineSystem.Web.HeadOffice.HeadOfficeActivity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" />
    <link href="../Content/style.css" rel="stylesheet" />
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
                <a class="navbar-brand" href="../Index.aspx">Community Medicine System</a>
            </div>
            <div class="collapse navbar-collapse" id="navbar-collapse">
                <ul class="nav navbar-nav">
                    <li><a href="../Index.aspx">Home <span class="sr-only">(current)</span></a></li>
                    <li><a href="#">Contact Us</a></li>
                </ul>

                <ul class="nav navbar-nav navbar-right">
                    <li><a href="http://www.facebook.com"><i class="fa fa-facebook-official fa-2x"></i></a></li>
                    <li><a href="http://www.twitter.com"><i class="fa fa-twitter fa-2x"></i></a></li>
                    <li><a href="http://www.youtube.com"><i class="fa fa-youtube fa-2x"></i></a></li>
                    <li><a href="../Login/Login.aspx">Centers</a></li>
                    <li class="active"><a href="#">Head Office</a></li>
                    <li>
                        <button type="button" runat="server" class="btn btn-default navbar-btn">Log out</button></li>
                </ul>
            </div>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="page-header">
            <h1>Head Office Activity</h1>
        </div>
        <div class="form-group">
            <div class="col-sm-12">
                <a class="btn btn-primary btn-lg btn-block" role="button" href="Setup/CenterSetup.aspx">Create New Center</a>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-12">
                <a class="btn btn-default btn-lg btn-block" role="button" href="Setup/DiseaseSetup.aspx">Disease Setup</a>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-12">
                <a class="btn btn-success btn-lg btn-block" role="button" href="Setup/MedicineSetup.aspx">Medicine Setup</a>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-12">
                <a class="btn btn-default btn-lg btn-block" role="button" href="SendMedicine.aspx">Send Medicine To Center</a>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-12">
                <a class="btn btn-info btn-lg btn-block" role="button" href="DiseaseWiseReport.aspx">Disease Wise Report</a>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-12">
                <a class="btn btn-default btn-lg btn-block" href="../HistoryOfPatient.aspx?action=head">History</a>
            </div>
        </div>
    </form>
    <script src="../Scripts/bootstrap.js"></script>
    <script src="../Scripts/jquery-2.1.3.js"></script>
    <script src="../Scripts/jquery.validate.js"></script>
    <script src="../Scripts/jquery.validate.min.js"></script>
    <script src="../Scripts/angular.js"></script>
</body>
</html>
