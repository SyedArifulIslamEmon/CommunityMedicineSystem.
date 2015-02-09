<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiseaseWiseReport.aspx.cs" Inherits="CommunityMedicineSystem.Web.HeadOffice.DiseaseWiseReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../datepicker/css/datepicker.css" rel="stylesheet" />
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
                    <li><a href="#">Head Office</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <form id="form1" class="form-horizontal" runat="server">
        <div class="form-group">
            <label class="col-sm-2 control-label">Select Disease</label>
            <div class="col-sm-5">
                <asp:DropDownList ID="diseaseDropDownList" CssClass="form-control" runat="server">
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-2 control-label">Date Between</label>
            <div class="col-sm-2">
                <asp:TextBox ID="firstDateTextBox" ReadOnly="True" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <label class="col-sm-1 control-label" style="margin: 0 30px 0 -30px;">and</label>
            <div class="col-sm-2">
                <asp:TextBox ID="lastDateTextBox" ReadOnly="True" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-5">
                <asp:Button ID="showButton" CssClass="btn btn-info btn-lg btn-block" runat="server" Text="Show" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-5">
                <asp:GridView ID="reportGridView" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False" Height="161px">
                    <Columns>
                        <asp:BoundField HeaderText="District Name" />
                        <asp:BoundField HeaderText="Total Patients" />
                        <asp:BoundField HeaderText="% Over Population" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-5">
                <asp:Button ID="printPdfButton" CssClass="btn btn-primary btn-lg btn-block" runat="server" Text="Print Pdf" />
            </div>
        </div>
    </form>
    <script src="../Scripts/jquery-2.1.3.js"></script>
    <script src="../Scripts/jquery-2.1.3.min.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../datepicker/js/bootstrap-datepicker.js"></script>
    <script src="../Scripts/jquery.validate.js"></script>
    <script src="../Scripts/jquery.validate.min.js"></script>
    <script src="../Scripts/angular.js"></script>
    <script>
        $(document).ready(function () {
            $(function () {
                $("#firstDateTextBox").datepicker();
                $("#lastDateTextBox").datepicker();
            });
        });
    </script>
</body>
</html>
