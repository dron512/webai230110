import React from 'react';

function MyComponents(props) {
    const name = props.name;
    return ( 
        <div>
            <span>{name}</span>
        </div> 
    );
}

export default MyComponents;