package com.example.demo.controller;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class MainApiController {

    @GetMapping("select")
    public String select(){
        return "안녕하세요";
    }

    @GetMapping("aa")
    public String aa(){
        return "aa10";
    }

    @GetMapping("bb")
    public String bb(){
        return "bb10";
    }

}
