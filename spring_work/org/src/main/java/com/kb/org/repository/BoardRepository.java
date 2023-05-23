package com.kb.org.repository;

import com.kb.org.model.Board;
import com.kb.org.model.Member;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

public interface BoardRepository extends JpaRepository<Board,Long> {
}

// JAVA -> JSP -> SPRING -> SPRINGBOOT