<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%@ page import="com.mh.org.AA" %>
<%
	AA a1 = new AA();
	String strresult = a1.getString();
	int addresult = a1.add(10, 20);
	double myrandom = a1.getRandom();
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
<h1>JSP PAGE</h1>
<h2>strresult = <%=strresult %></h2>
<h2>addresult = <%=addresult %></h2>
<h2>myrandom = <%=myrandom %></h2>
</body>
</html>