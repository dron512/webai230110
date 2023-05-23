package com.kb.org.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

import java.util.List;

@Getter
@Setter
@Entity
@ToString
public class Member extends BaseTimeEntity{

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;


    private String name;
    @Column(unique = true)
    private String email;
    private String pwd;
    private String gubun;

//    @OneToMany
//    List<Board> boardlist;
}
