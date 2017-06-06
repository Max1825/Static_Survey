<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="thanks.aspx.cs" Inherits="Survey.result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VN ASC 2017 Feedback Survey</title>
    <meta charset="utf-8">
	<meta name="keywords" content=""/>
    <meta name="description" content=""/>
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=yes" />
    <meta http-equiv="content-language" content="en" />
	
	<link rel="shortcut icon" href="content/images/favicon.ico" />
    
    <link type="text/css" rel="stylesheet" href="content/css/response.css" />    
    <link type="text/css" rel="stylesheet" href="content/css/style.css" />
    <link id="themeCssLink" rel="stylesheet" href="content/css/common.css" />

    <script type="text/javascript">
        var time = 15; 
        var page = "http://klvportal/SitePages/portal.aspx"; 
        function countDown(){
        time--;
        gett("timecount").innerHTML = time;
        if(time == -1){
        window.location = page;
        }
        }
        function gett(id){
        if(document.getElementById) return document.getElementById(id);
        if(document.all) return document.all.id;
        if(document.layers) return document.layers.id;
        if(window.opera) return window.opera.id;
        }
        function init(){
        if(gett('timecount')){
        setInterval(countDown, 1000);
        gett("timecount").innerHTML = time;
        }
        else{
        setTimeout(init, 50);
        }
        }
        document.onload = init();
    </script>



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
                        <h1>You have already completed to this survey!</h1>
                        <p>Thank you for taking the survey!</p>
                        <div style="margin-top:20px;">
                            <img src="content/images/completed.png" alt="Survey Completed" title="Survey Completed" />
                        </div>
						<div class="contact_detail">
						<p>You will be redirected to homepage in <span id="timecount" style="color:#FF0000;"></span> seconds!</p>

						<p>If you would like to help out with the next ASC, please contact the ASC Committee at <a href="mailto:HRcommunication@kepland.com.vn" style="text-transform:lowercase;color:#F49B00">HRcommunication@kepland.com.vn</a>
                            </p>
						</div>
                    </div>
			</form>
        </section>

    </article>
    
</body>
</html>
