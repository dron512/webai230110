import { useEffect, useState } from 'react';

export const useFetch = (p1) => {
  const [users, setUsers] = useState([]);
  const [loading, setLoding] = useState(true);
  useEffect(() => {
    setLoding(true);
    setUsers([]);
    fetch(`https://jsonplaceholder.typicode.com/${p1}`)
    .then( json => json.json())
    .then( result =>{
        setUsers(result);
        setLoding(false);
    })
  }, []);

  const fn = (p1)=>{
    setLoding(true);
    setUsers([]);
    fetch(`https://jsonplaceholder.typicode.com/${p1}`)
    .then( json => json.json())
    .then( result =>{
        setUsers(result);
        setLoding(false);
    })
  }

  return {users,loading,fn}
};
