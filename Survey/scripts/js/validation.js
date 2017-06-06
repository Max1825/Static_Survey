function Check_answer_1()
{
	var q1 = document.getElementById('q1_1_1').checked;
	var q2 = document.getElementById('q1_1_2').checked;
	var q3 = document.getElementById('q1_1_3').checked;
	var q4 = document.getElementById('q1_1_4').checked;
	var q5 = document.getElementById('q1_1_5').checked;
	
	var text;
	if (q1 == false && q2 == false && q3 == false && q4 == false && q5 == false )
	{	
	    alert("asjhdgashjfgas");
		//text = "Atleast choose one answer please?";	
		//window.location.hash = '#msg';
	}
	else 
	{
		text = " ";
	}
	document.getElementById("msg1").innerHTML = text;
}

function Check_answer_2()
{
	var q1 = document.getElementById('q2_1_1').checked;
	var q2 = document.getElementById('q2_1_2').checked;
	var q3 = document.getElementById('q2_1_3').checked;
	var q4 = document.getElementById('q2_1_4').checked;
	var q5 = document.getElementById('q2_1_5').checked;
	
	var q6 = document.getElementById('q2_2_1').checked;
	var q7 = document.getElementById('q2_2_2').checked;
	var q8 = document.getElementById('q2_2_3').checked;
	var q9 = document.getElementById('q2_2_4').checked;
	var q10 = document.getElementById('q2_2_5').checked;
	
	var q11 = document.getElementById('q2_3_1').checked;
	var q12 = document.getElementById('q2_3_2').checked;
	var q13 = document.getElementById('q2_3_3').checked;
	var q14 = document.getElementById('q2_3_4').checked;
	var q15 = document.getElementById('q2_3_5').checked;
	
	var q16 = document.getElementById('q2_4_1').checked;
	var q17 = document.getElementById('q2_4_2').checked;
	var q18 = document.getElementById('q2_4_3').checked;
	var q19 = document.getElementById('q2_4_4').checked;
	var q20 = document.getElementById('q2_4_5').checked;
	
	var test;
	if (q1 == false && q2 == false && q3 == false && q4 == false && q5 == false )
	{	
		text = "You havent't done section a?";	
		window.location.hash = '#msg';
	}
	elseif (q6 == false && q7 == false && q8 == false && q9 == false && q10 == false ) 
	{
		text = "You havent't done section b?";	
		window.location.hash = '#msg';
	}
	elseif (q11 == false && q12 == false && q13 == false && q14 == false && q15 == false ) 
	{
		text = "You havent't done section c?";	
		window.location.hash = '#msg';
	}
	elseif (q16 == false && q17 == false && q18 == false && q19 == false && q20 == false ) 
	{
		text = "You havent't done section d?";	
		window.location.hash = '#msg';
	}
	elseif ( q1 == false && q2 == false && q3 == false && q4 == false && q5 == false &&
			 q6 == false && q7 == false && q8 == false && q9 == false && q10 == false &&
			 q11 == false && q12 == false && q13 == false && q14 == false && q15 == false &&
			 q16 == false && q17 == false && q18 == false && q19 == false && q20 == false )
	{
		text = "Atleast choose one answer please?";	
		window.location.hash = '#msg';
	}
	else 
	{
		text = " ";
	}
	document.getElementById("msg2").innerHTML = text;
}

function Check_answer_3()
{
	var q1 = document.getElementById('q3_1').checked;
	var q2 = document.getElementById('q3_2').checked;
	
	var text;
	if(q1 == false && q2 == false)
	{	
		text = "Atleast choose one answer please?";	
		window.location.hash = '#msg';
	}
	else
	{
		text ="";
	}
	document.getElementById("msg").innerHTML = text;
}

function Check_answer_4()
{
	var q1 = document.getElementById('q4_1').checked;
	var q2 = document.getElementById('q4_2').checked;
	var q4 = document.getElementById('q4_3').checked;
	var q4 = document.getElementById('q4_4').checked;
	var q5 = document.getElementById('q4_5').checked;
	var q6 = document.getElementById('q4_6').checked;
	var q7 = document.getElementById('q4_7').checked;
	
	
	var text;
	if(q1 == false && q2 == false && q3 == false && q4 == false && q5 == false && q6 == false && q7 == false)
	{	
		text = "Atleast choose one answer please?";	
		window.location.hash = '#msg';
	}
	else
	{
		text ="";
	}
	document.getElementById("msg").innerHTML = text;
}

function Check_answer_5()
{
	var q1 = document.getElementById('q5_1_1').checked;
	var q2 = document.getElementById('q5_1_2').checked;
	var q3 = document.getElementById('q5_1_3').checked;
	var q4 = document.getElementById('q5_1_4').checked;
	
	var q5 = document.getElementById('q5_2_1').checked;
	var q6 = document.getElementById('q5_2_2').checked;
	var q7 = document.getElementById('q5_2_3').checked;
	var q8 = document.getElementById('q5_2_4').checked;
	
	var q9 = document.getElementById('q5_3_1').checked;
	var q10 = document.getElementById('q5_3_2').checked;
	var q11 = document.getElementById('q5_3_3').checked;
	var q12 = document.getElementById('q5_3_4').checked;
	
	var q13 = document.getElementById('q5_4_1').checked;
	var q14 = document.getElementById('q5_4_2').checked;
	var q15 = document.getElementById('q5_4_3').checked;
	var q16 = document.getElementById('q5_4_4').checked;
	
	var q17 = document.getElementById('q5_5_1').checked;
	var q18 = document.getElementById('q5_5_2').checked;
	var q19 = document.getElementById('q5_5_3').checked;
	var q20 = document.getElementById('q5_5_4').checked;
	
	var q21 = document.getElementById('q5_6_1').checked;
	var q22 = document.getElementById('q5_6_2').checked;
	var q23 = document.getElementById('q5_6_3').checked;
	var q24 = document.getElementById('q5_6_4').checked;
	
	var q25 = document.getElementById('q5_7_1').checked;
	var q26 = document.getElementById('q5_7_2').checked;
	var q27 = document.getElementById('q5_7_3').checked;
	var q28 = document.getElementById('q5_7_4').checked;
	
	var test;
	if (q1 == false && q2 == false && q3 == false && q4 == false )
	{	
		text = "You havent't done section a?";	
		window.location.hash = '#msg';
	}
	elseif (q5 == false && q6 == false && q7 == false && q8 == false) 
	{
		text = "You havent't done section b?";	
		window.location.hash = '#msg';
	}
	elseif ( q9 == false && q10 == false && q11 == false && q12 == false ) 
	{
		text = "You havent't done section c?";	
		window.location.hash = '#msg';
	}
	elseif (q13 == false && q14 == false && q15 == false && q16 == false) 
	{
		text = "You havent't done section d?";	
		window.location.hash = '#msg';
	}
	elseif (q17 == false && q18 == false && q19 == false && q20 == false )  
	{
		text = "You havent't done section d?";	
		window.location.hash = '#msg';
	}
	elseif (q21 == false && q22 == false && q23 == false && q24 == false )
	{
		text = "You havent't done section e?";	
		window.location.hash = '#msg';
	}
	elseif (q25 == false && q26 == false && q27 == false && q28 == false ) 
	{
		text = "You havent't done section f?";	
		window.location.hash = '#msg';
	}
	elseif ( q1 == false && q2 == false && q3 == false && q4 == false && q5 == false &&
			 q6 == false && q7 == false && q8 == false && q9 == false && q10 == false &&
			 q11 == false && q12 == false && q13 == false && q14 == false && q15 == false &&
			 q16 == false && q17 == false && q18 == false && q19 == false && q20 == false &&
			 q21 == false && q22 == false && q23 == false && q24 == false && q25 == false && q26 == false && q27 == false && q28 == false)
	{
		text = "Atleast choose one answer please?";	
		window.location.hash = '#msg';
	}
	else 
	{
		text = " ";
	}
	document.getElementById("msg").innerHTML = text;
}

function Check_answer_6()
{
	var q1 = document.getElementById('q6_1_1').checked;
	var q2 = document.getElementById('q6_1_2').checked;
	var q3 = document.getElementById('q6_1_3').checked;
	var q4 = document.getElementById('q6_1_4').checked;
	
	var q5 = document.getElementById('q6_2_1').checked;
	var q6 = document.getElementById('q6_2_2').checked;
	var q7 = document.getElementById('q6_2_3').checked;
	var q8 = document.getElementById('q6_2_4').checked;
	
	var q9 = document.getElementById('q6_3_1').checked;
	var q10 = document.getElementById('q6_3_2').checked;
	var q11 = document.getElementById('q6_3_3').checked;
	var q12 = document.getElementById('q6_3_4').checked;
	
	var q13 = document.getElementById('q6_4_1').checked;
	var q14 = document.getElementById('q6_4_2').checked;
	var q15 = document.getElementById('q6_4_3').checked;
	var q16 = document.getElementById('q6_4_4').checked;
	
	var q17 = document.getElementById('q6_5_1').checked;
	var q18 = document.getElementById('q6_5_2').checked;
	var q19 = document.getElementById('q6_5_3').checked;
	var q20 = document.getElementById('q6_5_4').checked;
	
	var q21 = document.getElementById('q6_6_1').checked;
	var q22 = document.getElementById('q6_6_2').checked;
	var q23 = document.getElementById('q6_6_3').checked;
	var q24 = document.getElementById('q6_6_4').checked;
	
	var q25 = document.getElementById('q6_7_1').checked;
	var q26 = document.getElementById('q6_7_2').checked;
	var q27 = document.getElementById('q6_7_3').checked;
	var q28 = document.getElementById('q6_7_4').checked;
	
	var test;
	if (q1 == false && q2 == false && q3 == false && q4 == false )
	{	
		text = "You havent't done section a?";	
		window.location.hash = '#msg';
	}
	elseif (q5 == false && q6 == false && q7 == false && q8 == false) 
	{
		text = "You havent't done section b?";	
		window.location.hash = '#msg';
	}
	elseif ( q9 == false && q10 == false && q11 == false && q12 == false ) 
	{
		text = "You havent't done section c?";	
		window.location.hash = '#msg';
	}
	elseif (q13 == false && q14 == false && q15 == false && q16 == false) 
	{
		text = "You havent't done section d?";	
		window.location.hash = '#msg';
	}
	elseif (q17 == false && q18 == false && q19 == false && q20 == false )  
	{
		text = "You havent't done section d?";	
		window.location.hash = '#msg';
	}
	elseif (q21 == false && q22 == false && q23 == false && q24 == false )
	{
		text = "You havent't done section e?";	
		window.location.hash = '#msg';
	}
	elseif (q25 == false && q26 == false && q27 == false && q28 == false ) 
	{
		text = "You havent't done section f?";	
		window.location.hash = '#msg';
	}
	elseif ( q1 == false && q2 == false && q3 == false && q4 == false && q5 == false &&
			 q6 == false && q7 == false && q8 == false && q9 == false && q10 == false &&
			 q11 == false && q12 == false && q13 == false && q14 == false && q15 == false &&
			 q16 == false && q17 == false && q18 == false && q19 == false && q20 == false &&
			 q21 == false && q22 == false && q23 == false && q24 == false && q25 == false && q26 == false && q27 == false && q28 == false)
	{
		text = "Atleast choose one answer please?";	
		window.location.hash = '#msg';
	}
	else 
	{
		text = " ";
	}
	document.getElementById("msg").innerHTML = text;
}

function Check_answer_11()
{
	var q1 = document.getElementById('q11_1_1').checked;
	var q2 = document.getElementById('q11_1_2').checked;
	var q3 = document.getElementById('q11_1_3').checked;
	var q4 = document.getElementById('q11_1_4').checked;
	var q5 = document.getElementById('q11_1_5').checked;
	
	var q6 = document.getElementById('q11_2_1').checked;
	var q7 = document.getElementById('q11_2_2').checked;
	var q8 = document.getElementById('q11_2_3').checked;
	var q9 = document.getElementById('q11_2_4').checked;
	var q10 = document.getElementById('q11_2_5').checked;
	
	var q11 = document.getElementById('q11_3_1').checked;
	var q12 = document.getElementById('q11_3_2').checked;
	var q13 = document.getElementById('q11_3_3').checked;
	var q14 = document.getElementById('q11_3_4').checked;
	var q15 = document.getElementById('q11_3_5').checked;
	
	var q16 = document.getElementById('q11_4_1').checked;
	var q17 = document.getElementById('q11_4_2').checked;
	var q18 = document.getElementById('q11_4_3').checked;
	var q19 = document.getElementById('q11_4_4').checked;
	var q20 = document.getElementById('q11_4_5').checked;
	
	var test;
	if (q1 == false && q2 == false && q3 == false && q4 == false && q5 == false )
	{	
		text = "You havent't done section a?";	
		window.location.hash = '#msg';
	}
	elseif (q6 == false && q7 == false && q8 == false && q9 == false && q10 == false ) 
	{
		text = "You havent't done section b?";	
		window.location.hash = '#msg';
	}
	elseif (q11 == false && q12 == false && q13 == false && q14 == false && q15 == false ) 
	{
		text = "You havent't done section c?";	
		window.location.hash = '#msg';
	}
	elseif (q16 == false && q17 == false && q18 == false && q19 == false && q20 == false ) 
	{
		text = "You havent't done section d?";	
		window.location.hash = '#msg';
	}
	elseif ( q1 == false && q2 == false && q3 == false && q4 == false && q5 == false &&
			 q6 == false && q7 == false && q8 == false && q9 == false && q10 == false &&
			 q11 == false && q12 == false && q13 == false && q14 == false && q15 == false &&
			 q16 == false && q17 == false && q18 == false && q19 == false && q20 == false )
	{
		text = "Atleast choose one answer please?";	
		window.location.hash = '#msg';
	}
	else 
	{
		text = " ";
	}
	document.getElementById("msg").innerHTML = text;
}

function Check_answer_13()
{
	var q1 = document.getElementById('q13_0').checked;
	var q2 = document.getElementById('q13_1').checked;
	var q3 = document.getElementById('q13_2').checked;
	var q4 = document.getElementById('q13_3').checked;
	var q5 = document.getElementById('q13_4').checked;
	var q6 = document.getElementById('q13_5').checked;
	var q7 = document.getElementById('q13_6').checked;
	var q8 = document.getElementById('q13_7').checked;
	var q9 = document.getElementById('q13_8').checked;
	var q10 = document.getElementById('q13_9').checked;
	var q11 = document.getElementById('q13_10').checked;
	var text;
	if (q1 == false && q2 == false && q3 == false && q4 == false && q5 == false &&
		q6 == false && q7 == false && q8 == false && q9 == false && q10 == false && q11 == false)
	{	
		text = "Atleast choose one answer please?";	
		window.location.hash = '#msg';
	}
	else 
	{
		text = " ";
	}
	document.getElementById("msg").innerHTML = text;
}

function Check_answer_16()
{
	var q1 = document.getElementById('q16_0').checked;
	var q2 = document.getElementById('q16_1').checked;
	var q3 = document.getElementById('q16_2').checked;
	var q4 = document.getElementById('q16_3').checked;
	var q5 = document.getElementById('q16_4').checked;
	var q6 = document.getElementById('q16_5').checked;
	var q7 = document.getElementById('q16_6').checked;
	var q8 = document.getElementById('q16_7').checked;
	var q9 = document.getElementById('q16_8').checked;
	var q10 = document.getElementById('q16_9').checked;
	var q11 = document.getElementById('q16_10').checked;
	var text;
	if (q1 == false && q2 == false && q3 == false && q4 == false && q5 == false &&
		q6 == false && q7 == false && q8 == false && q9 == false && q10 == false && q11 == false)
	{	
		text = "Atleast choose one answer please?";	
		window.location.hash = '#msg';
	}
	else 
	{
		text = " ";
	}
	document.getElementById("msg").innerHTML = text;
}

function Check_answer_17()
{
	var q1 = document.getElementById('q17_1_1').checked;
	var q2 = document.getElementById('q17_1_2').checked;
	var q3 = document.getElementById('q17_1_3').checked;
	var q4 = document.getElementById('q17_1_4').checked;
	var q5 = document.getElementById('q17_1_5').checked;
	
	var q6 = document.getElementById('q17_2_1').checked;
	var q7 = document.getElementById('q17_2_2').checked;
	var q8 = document.getElementById('q17_2_3').checked;
	var q9 = document.getElementById('q17_2_4').checked;
	var q10 = document.getElementById('q17_2_5').checked;
	
	var q11 = document.getElementById('q17_3_1').checked;
	var q12 = document.getElementById('q17_3_2').checked;
	var q13 = document.getElementById('q17_3_3').checked;
	var q14 = document.getElementById('q17_3_4').checked;
	var q15 = document.getElementById('q17_3_5').checked;
	
	var test;
	if (q1 == false && q2 == false && q3 == false && q4 == false && q5 == false )
	{	
		text = "You havent't done section a?";	
		window.location.hash = '#msg';
	}
	elseif (q6 == false && q7 == false && q8 == false && q9 == false && q10 == false ) 
	{
		text = "You havent't done section b?";	
		window.location.hash = '#msg';
	}
	elseif (q11 == false && q12 == false && q13 == false && q14 == false && q15 == false ) 
	{
		text = "You havent't done section c?";	
		window.location.hash = '#msg';
	}
	elseif ( q1 == false && q2 == false && q3 == false && q4 == false && q5 == false &&
			 q6 == false && q7 == false && q8 == false && q9 == false && q10 == false &&
			 q11 == false && q12 == false && q13 == false && q14 == false && q15 == false)
	{
		text = "Atleast choose one answer please?";	
		window.location.hash = '#msg';
	}
	else 
	{
		text = " ";
	}
	document.getElementById("msg").innerHTML = text;
}

function CheckAll()
{
		Check_answer_1();
		Check_answer_2();
		Check_answer_3();
		Check_answer_4();
		Check_answer_5();
		Check_answer_6();
		Check_answer_11();
		Check_answer_13();
		Check_answer_17();
}



