package com.example.demo.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class MainController {

    @GetMapping("/")
    public String index(Model model){
        String a = "10";
        String b = "20";
        String c = a+b;

        for(int i=0; i<10; i++){
            System.out.println(i);
        }


        model.addAttribute("title","안녕하세요");
        model.addAttribute("abc","abcdefg");
        return "index";
    }
}
