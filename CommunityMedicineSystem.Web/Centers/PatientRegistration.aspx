<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="PatientRegistration.aspx.cs" Inherits="CommunityMedicineSystem.Web.Centers.PatientRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" ng-app="myApp">
<head runat="server">
    <title>Patient Registration</title>
    <link href="../Content/bootstrap-theme.css" rel="stylesheet" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../datepicker/css/datepicker.css" rel="stylesheet" />
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" />
    <link href="../Content/style.css" rel="stylesheet" />
</head>
<body ng-controller="myController">
    <nav class="navbar navbar-default navbar-fixed-top">
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
                    <li><a href="../Centers/CenterActivity.aspx">Centers</a></li>
                    <li class="active"><a href="../HeadOffice/HeadOfficeActivity.aspx">Head Office</a></li>
                    <%--<li><asp:Button ID="logOutButton" runat="server" Text="Log Out" /></li>--%>--%>
                    <li><button type="button" runat="server" class="btn btn-default navbar-btn">Log out</button></li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="page-header" style="margin-top: 100px;">
        <div class="form-group">
            <h1 style="margin-left: -200px;">Patient Registration</h1>
        </div>
    </div>
    <div runat="server" class="container content_top">
        <form class="form-horizontal" runat="server">
            <div class="form-group">
                <label class="col-sm-2 control-label">Voter Id</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="voterIdTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-sm-2">
                    <asp:Button ID="showDetailsButton" CssClass="btn btn-success" runat="server" Text="Show Details" OnClick="showDetailsButton_Click" />
                </div>
                    <label class="col-sm-2 alert alert-danger" id="errorlabel" runat="server"></label>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Name</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="nameTextBox" ReadOnly="True" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Address</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="addressTextBox" ReadOnly="True" TextMode="MultiLine" Height="60px" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Age</label>
                <div class="col-sm-6">
                    <asp:TextBox ID="ageTextBox" ReadOnly="True" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Service Given</label>
                <div class="col-sm-1">
                    <asp:TextBox ID="serviceGivenTextBox" ReadOnly="True" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <label class="col-sm-1 control-label" style="margin-left: -40px;">Times</label>
            </div>
            <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                    <asp:Button ID="showHistoryButton" CssClass="btn btn-default btn-lg btn-block" runat="server" Text="Show All History" OnClick="showHistoryButton_Click" />
                    <%--<a href="../HistoryOfPatient.aspx.cs?action=center&voterId=<% %>" role="button" class="btn btn-default btn-lg btn-block">Show All History</a>--%>
                </div>
            </div>
            <hr />
            <div class="form-group">
                <label class="col-sm-2 control-label">Observation</label>
                <div class="col-sm-2">
                    <asp:TextBox ID="observationTextBox" ng-model="observation" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <label class="col-sm-1 control-label">Date</label>
                <div class="col-sm-2">
                    <div class="form-group">
                        <div class="input-group date">
                            <input type="text" id="dateTextBox" ng-model="serviceDate"  class="form-control" readonly="readonly" runat="server"/>
                            <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span>
                            </span>
                        </div>
                    </div>
                </div>
                <label class="col-sm-1 control-label">Doctor</label>
                <div class="col-sm-2">
                    <asp:DropDownList ng-model="doctor" ID="doctorDropDownList" CssClass="form-control" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Disease</label>
                <div class="col-sm-2">
                    <asp:DropDownList ID="diseaseDropDownList" ng-model="disease" CssClass="form-control" runat="server">
                    </asp:DropDownList>
                </div>
                <label class="col-sm-1 control-label">Medicine</label>
                <div class="col-sm-2">
                    <asp:DropDownList ID="medicinedropDownList" ng-model="medicine" CssClass="form-control" runat="server">
                    </asp:DropDownList>
                </div>
                <label class="col-sm-1 control-label">Dose</label>
                <div class="col-sm-2">
                    <asp:DropDownList ID="doseDropDownList" ng-model="dose" CssClass="form-control" runat="server">
                        <asp:ListItem>1+0+0</asp:ListItem>
                        <asp:ListItem>1+1+0</asp:ListItem>
                        <asp:ListItem>1+0+1</asp:ListItem>
                        <asp:ListItem>1+1+1</asp:ListItem>
                        <asp:ListItem>0+0+1</asp:ListItem>
                        <asp:ListItem>0+1+1</asp:ListItem>
                        <asp:ListItem>0+1+0</asp:ListItem>
                        <asp:ListItem>1+1+1+1</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-sm-2">
                    <input type="radio" class="radio radio-inline" value="After Meal" ng-model="meal" style="margin-left: -20px" />After Meal
                    <input type="radio" class="radio radio-inline" value="Before Meal" ng-model="meal" />Before Meal
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-2 control-label">Quantity Given</label>
                <div class="col-sm-2">
                    <asp:TextBox ID="quantityGivenTextBox" ng-model="quantity" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <label class="col-sm-1 control-label">Note</label>
                <div class="col-sm-5">
                    <asp:TextBox ID="noteTextBox" ng-model="note" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-sm-2">
                    <input id="addButton" type="button" value="Add" ng-click="AddInfo(disease,medicine,dose,meal,quantity,note);" class="btn btn-success" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                    <table id="stockTable" runat="server" class="table table-bordered">
                        <thead>
                            <tr>
                                <td>Disease</td>
                                <td>Medicine</td>
                                <td>Dose</td>
                                <td>After/Before Meal</td>
                                <td>Quantity Given</td>
                                <td>Note</td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="aInfo in info">
                                <td>{{aInfo.Disease}}</td>
                                <td>{{aInfo.Medicine}}</td>
                                <td>{{aInfo.Dose}}</td>
                                <td>{{aInfo.Meal}}</td>
                                <td>{{aInfo.Quantity}}</td>
                                <td>{{aInfo.Note}}</td>
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
            <div class="alert alert-dismissible">
                <p>
                    <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
                </p>
            </div>
            <input type="hidden" id="diseases" runat="server" />
            <input type="hidden" id="medicines" runat="server" />
            <input type="hidden" id="doses" runat="server" />
            <input type="hidden" id="meals" runat="server" />
            <input type="hidden" id="quantities" runat="server" />
            <input type="hidden" id="notes" runat="server" />
        </form>
    </div>
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
                $("#dateTextBox").datepicker();
            });
        });

        var myApplication = angular.module("myApp", []);
        myApplication.controller("myController", function ($scope) {
            $scope.info = [];
            $scope.AddInfo = function (disease, medicine, dose, meal, quantity, note) {
                if (disease != String.empty && meal != String.empty && medicine != String.empty && dose != String.empty && quantity != String.empty) {
                    $scope.info.push({ Disease: disease, Quantity: quantity, Medicine: medicine, Dose: dose, Meal: meal, Note: note });
                    var medicineName = medicine.split(",");
                    document.getElementById("diseases").value += disease + ",";
                    document.getElementById("medicines").value += medicineName[0] + ",";
                    document.getElementById("doses").value += dose + ",";
                    document.getElementById("meals").value += meal + ",";
                    document.getElementById("quantities").value += quantity + ",";
                    document.getElementById("notes").value += note + ",";
                }
            };
        });
    </script>
</body>
</html>
