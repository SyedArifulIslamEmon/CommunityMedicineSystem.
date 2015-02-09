<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="SendMedicine.aspx.cs" Inherits="CommunityMedicineSystem.Web.HeadOffice.SendMedicine" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" ng-app="myApp">
<head runat="server">
    <title>Medicine Setup</title>
    <link href="../Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" />
    <link href="../Content/style.css" rel="stylesheet" />
</head>
<body ng-controller="myController">
    <nav class="navbar navbar-default navbar-fixed-top">
        <div class="container-fluid">
            <div class="navbar-header">;
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
                    <%--<li>
                        <button type="button" runat="server" class="btn btn-default navbar-btn">Log out</button></li>--%>
                </ul>
            </div>
        </div>
    </nav>
    <div class="page-header" style="margin-top: 100px;">
        <div class="form-group">
            <h1 style="margin-left: -200px;">Send Medicine to the Center</h1>
        </div>
    </div>
    <div class="container content_top">
        <form class="form-horizontal" runat="server" id="medicineSendForm" action="SendMedicine.aspx" method="POST">
            <div class="form-group">
                <label class="col-sm-2 control-label">District</label>
                <div class="col-sm-6">
                    <asp:DropDownList ID="districtDropDownList" CssClass="form-control" runat="server" OnSelectedIndexChanged="districtDropDownList_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Thana</label>
                <div class="col-sm-6">
                    <asp:DropDownList ID="thanaDropDownList" CssClass="form-control" runat="server" OnSelectedIndexChanged="thanaDropDownList_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Center</label>
                <div class="col-sm-6">
                    <asp:DropDownList ID="centerDropDownList" CssClass="form-control" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Add Medicine</label>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Select Medicine</label>
                <div class="col-sm-2">
                    <asp:DropDownList ID="medicineDropDownList" ng-model="name" CssClass="form-control" runat="server">
                    </asp:DropDownList>
                </div>
                <label class="col-sm-1 control-label">Quantity</label>
                <div class="col-sm-2">
                    <asp:TextBox ID="quantityTextBox" ng-model="quantity" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-sm-4">
                    <input id="addButton" type="button" value="Add" ng-click="AddMedicine(name,quantity);" class="btn btn-success" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-offset-2 col-sm-6">
                    <table id="stockTable" runat="server" class="table table-bordered">
                        <thead>
                            <tr>
                                <td>Name</td>
                                <td>Quantity</td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="aMedicine in medicines">
                                <td>{{aMedicine.Name}}</td>
                                <td>{{aMedicine.Quantity}}</td>
                            </tr>
                        </tbody>
                    </table>
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
            <input type="hidden" id="medicineNames" runat="server" />
            <input type="hidden" id="medicineQuantities" runat="server" />
        </form>
    </div>
    <script src="../Scripts/bootstrap.js"></script>
    <script src="../Scripts/jquery-2.1.3.js"></script>
    <script src="../Scripts/jquery.validate.js"></script>
    <script src="../Scripts/jquery.validate.min.js"></script>
    <script src="../Scripts/angular.js"></script>
    <script src="../Scripts/jsScripts/SendMedicine.js"></script>
</body>
</html>
