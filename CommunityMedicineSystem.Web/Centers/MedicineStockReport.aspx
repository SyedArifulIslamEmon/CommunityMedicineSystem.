<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicineStockReport.aspx.cs" Inherits="CommunityMedicineSystem.Web.Centers.MedicineStockReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Medicine stock Report</title>
    <link href="../HeadOffice/../Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="../HeadOffice/../Content/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" />
    <link href="../HeadOffice/../Content/style.css" rel="stylesheet" />
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
                <a class="navbar-brand" href="../HeadOffice/../Index.aspx">Community Medicine System</a>
            </div>
            <div class="collapse navbar-collapse" id="navbar-collapse">
                <ul class="nav navbar-nav">
                    <li><a href="../HeadOffice/../Index.aspx">Home <span class="sr-only">(current)</span></a></li>
                    <li><a href="#">Contact Us</a></li>
                </ul>

                <ul class="nav navbar-nav navbar-right">
                    <li><a href="http://www.facebook.com"><i class="fa fa-facebook-official fa-2x"></i></a></li>
                    <li><a href="http://www.twitter.com"><i class="fa fa-twitter fa-2x"></i></a></li>
                    <li><a href="http://www.youtube.com"><i class="fa fa-youtube fa-2x"></i></a></li>
                    <li class="active"><a href="CenterActivity.aspx">Centers</a></li>
                    <li><a href="../HeadOffice/HeadOfficeActivity.aspx">Head Office</a></li>
                    <li><button type="button" runat="server" class="btn btn-default navbar-btn" onclick="window.location='../Index.aspx'">Log out</button></li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="page-header">
        <div class="form-group">
            <h1 style="margin-left: -200px;">Medicine Stock Report</h1>
        </div>
    </div>
    <form runat="server">
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-6">
                <asp:GridView ID="stockReportGridView" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="MedicineName" HeaderText="Medicine Name" SortExpression="Name" />
                        <asp:BoundField DataField="MedicineQuantity" HeaderText="Present Stock" SortExpression="Quantity" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
    <script src="../HeadOffice/../Scripts/bootstrap.js"></script>
    <script src="../HeadOffice/../Scripts/jquery-2.1.3.js"></script>
    <script src="../HeadOffice/../Scripts/jquery.validate.js"></script>
    <script src="../HeadOffice/../Scripts/jquery.validate.min.js"></script>
    <script>
        $(document).ready(function () {

        });
    </script>
</body>

</html>
