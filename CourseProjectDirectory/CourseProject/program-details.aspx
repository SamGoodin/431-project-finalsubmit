<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="program-details.aspx.cs" Inherits="CourseProject.program_details" %>
<%@ Register TagPrefix="general" TagName="Frame" Src="WebFrame.ascx" %>
<%@ Register TagPrefix="general" TagName="Footer" Src="WebFooter.ascx" %>

<!DOCTYPE html>
<!--
	Transitive by TEMPLATED
	templated.co @templatedco
	Released for free under the Creative Commons Attribution 3.0 license (templated.co/license)
-->
<html>
<head>
    <title>Project Details</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="assets/css/main.css" />
</head>
<body>

        <!-- Using WebFrame.ascx -->
        <general:Frame ID="idFrame" runat="server" />


            <!-- PAGE CONTENT -->
            <section class="wrapper">
                <div class="inner">
                <div class="box">
                      <div class="content">                        
                        <h1 class="align-center">Project Details</h1>
                        <hr />
                          <asp:Literal ID="ltrlError1" runat="server"></asp:Literal>

                        <form action="#" method="post" runat="server">



                            <%-- program name --%>
                            <div class="first field half">                                
                                <asp:Label ID="lblProgramName" Font-Bold="true" runat ="server">Program Name:</asp:Label>
                                <asp:Label ID="programName" runat="server" Text=""></asp:Label>
                            </div>

                            <%-- Start Date of Program --%>
                            <div class="field half">
                                <asp:Label ID="lblStartDate" Font-Bold="true" runat ="server">Program Start Date:</asp:Label>
                                <asp:Label ID="lblStartDateText" runat="server" ></asp:Label>                                                                
                            </div>

                             <%-- program Application Deadline --%>
                            <div class="first field half">                                
                                <asp:Label ID="lblApplicationDeadline" Font-Bold="true" runat ="server">Program Application Deadline:</asp:Label>
                                <asp:Label ID="lblApplicationDeadlineText" runat="server" Text=""></asp:Label>
                            </div>

                            <%-- Program Description--%>
                            <div class="field half">
                                <asp:Label ID="lblDescription" Font-Bold="true" runat ="server">Program Description:</asp:Label>
                                <asp:Label ID="lblDescriptionText" runat="server" ></asp:Label>                                                                
                            </div>

                            <%-- program Additional Restrictions--%>
                            <div class="first field half">                                
                                <asp:Label ID="lblAdditionalRestrictions" Font-Bold="true" runat ="server">Additional Restrictions:</asp:Label>
                                <asp:Label ID="lblAdditionalRestrictionsText" runat="server" Text=""></asp:Label>
                            </div>

                            <%-- Program website--%>
                            <div class="field half">
                                <asp:Label ID="lblWebsite" Font-Bold="true" runat ="server">Program Website:</asp:Label>
                                <asp:Label ID="lblWebsiteText" runat="server" ></asp:Label>                                                                
                            </div>

                             <%-- program Cost--%>
                            <div class="first field half">                                
                                <asp:Label ID="lblCost" Font-Bold="true" runat ="server">Program Cost:</asp:Label>
                                <asp:Label ID="lblCostText" runat="server" Text=""></asp:Label>
                            </div>

                            <%-- Program field--%>
                            <div class="field half">
                                <asp:Label ID="lblField" Font-Bold="true" runat ="server">Program Field of Study:</asp:Label>
                                <asp:Label ID="lblFieldText" runat="server" ></asp:Label>                                                                
                            </div>

                             <%-- program Length--%>
                            <div class="first field half">                                
                                <asp:Label ID="lbllength" Font-Bold="true" runat ="server">Length of Program:</asp:Label>
                                <asp:Label ID="lblLengthText" runat="server" Text=""></asp:Label>
                            </div>

                            <%-- Program Gradelevel--%>
                            <div class="field half">
                                <asp:Label ID="lblGradeLevel" Font-Bold="true" runat ="server">Grade Level:</asp:Label>
                                <asp:Label ID="lblGradeLevelText" runat="server" ></asp:Label>                                                                
                            </div>
                            <%-- program residential type--%>
                            <div class="first field half">                                
                                <asp:Label ID="lblResidence" Font-Bold="true" runat ="server">Residence Type Provided:</asp:Label>
                                <asp:Label ID="lblResidenceText" runat="server" Text=""></asp:Label>
                            </div>

                            <%-- Program season name--%>
                            <div class="field half">
                                <asp:Label ID="lblSeason" Font-Bold="true" runat ="server">Program During Season:</asp:Label>
                                <asp:Label ID="lblSeasonText" runat="server" ></asp:Label>                                                                
                            </div>

                            <%-- program service area--%>
                            <div class="first field half">                                
                                <asp:Label ID="lblServiceArea" Font-Bold="true" runat ="server">Program Service Area:</asp:Label>
                                <asp:Label ID="lblServiceAreaText" runat="server" Text=""></asp:Label>
                            </div>

                            <%-- Program Stipend Amount--%>
                            <div class="field half">
                                <asp:Label ID="lblStipend" Font-Bold="true" runat ="server">Program Stipend Options:</asp:Label>
                                <asp:Label ID="lblStipendText" runat="server" ></asp:Label>                                                                
                            </div>

                             <%-- program last Updatede --%>
                            <div class="first field half">                                
                                <asp:Label ID="lblLastUpdated" Font-Bold="true" runat ="server">Program Last Updated:</asp:Label>
                                <asp:Label ID="lblLastUpdatedText" runat="server" Text=""></asp:Label>
                            </div>
                            
                          <asp:Button ID="btnBackToSearch" class="button special" OnClick="btnBack_Click" runat="server" Text="Back to Search" />

                            <asp:Literal ID="ltrlSqlError" runat="server"></asp:Literal>
                        </form>
                    </div>
                    </div>
                    </div>
                </section>

    <!-- Using WebFooter.ascx -->
    <general:Footer ID="idFoot" runat="server" />

    <!-- Scripts -->
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/jquery.scrolly.min.js"></script>
    <script src="assets/js/jquery.scrollex.min.js"></script>
    <script src="assets/js/skel.min.js"></script>
    <script src="assets/js/util.js"></script>
    <script src="assets/js/main.js"></script>

</body>
</html>



