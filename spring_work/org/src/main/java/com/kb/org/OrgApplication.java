package com.kb.org;

import com.kb.org.test.AA;
import com.kb.org.test.BB;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.data.jpa.repository.config.EnableJpaAuditing;

import java.util.ArrayList;
import java.util.List;

@SpringBootApplication
@EnableJpaAuditing
public class OrgApplication {

	public static void main(String[] args) {

		SpringApplication.run(OrgApplication.class, args);

		// Collection generic...
//		AA a1 = new AA();
//		a1.setA("a11a11");
//		a1.setB(10);
//
//		AA a2 = new AA();
//		a2.setA("a11a11");
//		a2.setB(10);
//
//		List<AA> list = new ArrayList<>();
//		list.add(a1);
//		list.add(a2);
//
//		System.out.println(list);
//
//		BB<String,AA> bb = new BB<>();
//
//		bb.setT("T입니다");
//		bb.setK(a1);
//
//		System.out.println(bb);
//
//		BB<Integer,String> bb2 = new BB();
//		bb2.setT(10);
//		bb2.setK("문자열");
//
//		System.out.println(bb2);
	}

}
