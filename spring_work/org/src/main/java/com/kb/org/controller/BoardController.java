package com.kb.org.controller;

import com.kb.org.model.Board;
import com.kb.org.repository.BoardRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import java.util.List;

//url 주소 호출
@Controller
@RequestMapping("board")
public class BoardController {

    @Autowired
    BoardRepository boardRepository;

    // http://localhost:8080/board/select
    @GetMapping("select")
    public String select(){
        List<Board> list = boardRepository.findAll();
        System.out.println(list);
        return "board";
    }

    // http://localhost:8080/board/insert
    @GetMapping("insert")
    public String insert(){
        boardRepository.save(new Board());
        return "board";
    }

}
