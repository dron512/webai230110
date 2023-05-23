package com.kb.org.controller;


import com.kb.org.model.Member;
import com.kb.org.repository.MemberRepository;
import com.kb.org.test.MyA;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class MainController {

    @Autowired
    MemberRepository memberRepository;

    @Autowired
    MyA myA;

    @GetMapping("/")
    public String main(){

        System.out.println(myA.getA());
        myA.doA();

        Member member1 = new Member();
        Member member2 = new Member();

        member1.setName("name1");
        member1.setEmail("aa@naver.com");

        member2.setName("name2");
        member2.setEmail("bb@naver.com");

        //insert 구문 자동 만들기
        memberRepository.save(member1);
        memberRepository.save(member2);


        System.out.println("일로오나");
        return "main";
    }

}


