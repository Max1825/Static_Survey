<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="report.aspx.cs" Inherits="Survey.report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VN ASC 2017 Report</title>
    <meta charset="utf-8">
	<meta name="keywords" content=""/>
    <meta name="description" content=""/>
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=yes" />
    <meta http-equiv="content-language" content="en" />
	
	<link rel="shortcut icon" href="content/images/favicon.ico" />
    
    <link type="text/css" rel="stylesheet" href="content/css/response.css" />    
    <link type="text/css" rel="stylesheet" href="content/css/style.css" />
    <link id="themeCssLink" rel="stylesheet" href="content/css/common.css" />
</head>
<body id="patas" class="translate survey-body modern-browser">
    <article class="survey-page survey-page-white ">
        <header class="survey-page-header">
            <div class="survey-title-container clearfix
                survey-title-align-left has-survey-title ">
                <div class="survey-title-table-wrapper">
                    <table role="presentation" class="survey-title-table table-reset" style="text-align:center;width:100%;">
                        <tbody>
                            <tr>
                                <td style="text-align:center;width:100%; margin: 0 auto;">
                                    <h1 class="survey-title user-generated notranslate" style="font-size:30px;">
                                        <span class="title-text">
                                            Keppel Land Vietnam Annual Staff Conference 2017 Feedback
                                        </span>
                                    </h1>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </header>


        <section class="survey-page-body">
            <form name="surveyForm"  method="post" enctype="multipart/form-data" novalidate data-survey-page-form runat="server">                                    
                    <div class="survey-submit-actions center-text clearfix">
                        <h1>List Users Done</h1>
						<div class="contact_detail">
                            <div style="float:left;">
                                <asp:Label ID="Label1" runat="server" Text="" />
                            </div>
                            
						    <asp:PlaceHolder ID="PlaceHolder1" runat="server" />
						</div>
                    </div>
			</form>
        </section>

    </article>
    
</body>
</html>
