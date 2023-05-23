package com.kb.org.controller;

import com.kb.org.model.Member;
import com.kb.org.repository.MemberRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;


@RestController
@RequestMapping("memberapi")
public class MemberApiController {

    @Autowired
    MemberRepository memberRepository;
    @GetMapping("select")
    public List<Member> select(){
        // select * from member;
        List<Member> list = memberRepository.findAll();
        return list;
    }

    @PostMapping("insert")
    public String insert(@RequestBody Member reqm){
        System.out.println(reqm);
        memberRepository.save(reqm);
        return "insert됨";
    }

    @PostMapping("delete")
    public String delete(@RequestBody Member reqm){
        Member dbMember = memberRepository.findById(reqm.getId()).orElse(null);
        if(dbMember == null) {
            return "삭제할행이 없다.";
        }
        else {
            memberRepository.delete(reqm);
            return "delete됨";
        }
    }

    @PostMapping("update")
    public String update(@RequestBody Member reqm){
        Member dbMember = memberRepository.findById(reqm.getId()).orElse(null);
        if(dbMember == null) {
            return "수정할행이 없다.";
        }
        else {
            memberRepository.save(reqm);
            return "update됨";
        }
    }

}
