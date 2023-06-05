package com.kb.org.model;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

import java.time.LocalDate;

@Getter
@Setter
@Entity
@ToString
public class Vacation extends BaseTimeEntity{
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    @Column(name = "id", nullable = false)
    private Long id;

    private int month;
    private LocalDate startdate;
    private LocalDate enddate;
    private int fordate;
    private String classname;
    private String name;
    private LocalDate birthdate;
    private String address;
    private String phonenumber;
    private String reason;

    private LocalDate reasondate;




}
