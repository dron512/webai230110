package com.kb.org.controller;

import com.kb.org.model.Member;
import com.kb.org.repository.MemberRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;


@RestController
@RequestMapping("member")
public class MemberController {

    @Autowired
    MemberRepository memberRepository;
    @GetMapping("select")
    public List<Member> select(){
        // select * from member;
        List<Member> list = memberRepository.findAll();
        return list;
    }

    @PostMapping("insert")
    public String insert(){
        Member memeber = new Member();
        memeber.setName("aaa");
        memeber.setEmail("aaa@naver.com");
        memberRepository.save(memeber);
        return "insert됨";
    }

}
