<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CenterActivity.aspx.cs" Inherits="CommunityMedicineSystem.Web.Centers.NewPageUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Center Activity</title>
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
                    <li class="active"><a href="#">Centers</a></li>
                    <li><a href="../HeadOffice/HeadOfficeActivity.aspx">Head Office</a></li>
                    <li>
                        <button type="button" class="btn btn-default navbar-btn" onclick="window.location='../Index.aspx'">Log out</button></li>
                </ul>
            </div>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="page-header">
            <h1>Center Activity</h1>
        </div>
        <div class="form-group">
            <div class="col-sm-12">
                <a class="btn btn-primary btn-lg btn-block" role="button" href="DoctorSetup.aspx">Doctor Entry</a>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-12">
                <a class="btn btn-default btn-lg btn-block" role="button" href="MedicineStockReport.aspx">Medicine Stock Report</a>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-12">
                <a class="btn btn-primary btn-lg btn-block" role="button" href="PatientRegistration.aspx">Patients Registration</a>
            </div>
        </div>
    </form>
</body>
</html>
