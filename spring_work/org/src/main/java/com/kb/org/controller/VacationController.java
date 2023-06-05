package com.kb.org.controller;

import com.kb.org.model.Vacation;
import com.kb.org.repository.VacationRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;


@RestController
@RequestMapping("vacationapi")
public class VacationController {

    @Autowired
    VacationRepository vacationRepository;

    @GetMapping("select")
    public List<Vacation> select(){
        List<Vacation> list = vacationRepository.findAll();
        return list;
    }

    @PostMapping("insert")
    public String insert(@RequestBody Vacation reqm){
        System.out.println(reqm);
        vacationRepository.save(reqm);
        return "insert됨";
    }

    @PostMapping("delete")
    public String delete(@RequestBody Vacation reqm){
        Vacation dbVacation = vacationRepository.findById(reqm.getId()).orElse(null);
        if(dbVacation == null) {
            return "삭제할행이 없다.";
        }
        else {
            vacationRepository.delete(reqm);
            return "delete됨";
        }
    }

    @PostMapping("update")
    public String update(@RequestBody Vacation reqm){
        Vacation dbVacation = vacationRepository.findById(reqm.getId()).orElse(null);
        if(dbVacation == null) {
            return "수정할행이 없다.";
        }
        else {
            vacationRepository.save(reqm);
            return "update됨";
        }
    }

}
