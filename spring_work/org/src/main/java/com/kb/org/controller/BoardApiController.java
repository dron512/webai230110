package com.kb.org.controller;

import com.kb.org.model.Board;
import com.kb.org.repository.BoardRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("boardapi")
public class BoardApiController {

    @Autowired
    BoardRepository boardRepository;
    @GetMapping
    public List<Board> select(){
        // select * from board;
        List<Board> list = boardRepository.findAll();
        return list;
    }
}
