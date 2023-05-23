package com.kb.org.test;

import lombok.Getter;
import lombok.Setter;
import lombok.ToString;
import org.springframework.stereotype.Component;

@Component
@ToString
@Getter
@Setter
public class MyA {

    private String a = "A입니다";

//    public String toString(){
//        return "aaaaa";
//    }

//    public String getA() {
//        return a;
//    }
//
//    public void setA(String a) {
//        this.a = a;
//    }

    public void doA(){
        System.out.println("MyA doA 함수입니다.");
    }

}
