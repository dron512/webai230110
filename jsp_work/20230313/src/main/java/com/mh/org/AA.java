package com.mh.org;

class A{
	public double getRandom() {
		return Math.random()*50;
	}
}

public class AA extends A {
	
	public String getString() {
		return "AA class getString ";
	}
	
	public int add(int a,int b) {
		return a+b;
	}
}
