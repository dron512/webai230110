function Student({student}) {
    console.log(student);
    return ( <>
        <span>{student.name}</span>
        <span>{student.kor}</span>
        <span>{student.eng}</span>
        <span>{student.math}</span>
        <span>{student.scy}</span>
    </> );
}

export default Student;