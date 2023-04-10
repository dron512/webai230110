import React from 'react';
import styled from 'styled-components';
import { Button } from 'react-bootstrap';

export const Home = () => {
    return (
        <ContentDiv>
            <h1>HOME</h1>
            <Button>부트버튼</Button>
        </ContentDiv>
    );
};

export const Menu1 = () => {
    return (
        <div>
            <h1>MENU1</h1>
        </div>
    );
};

export const Menu2 = () => {
    return (
        <div>
            <h1>MENU2</h1>
        </div>
    );
};

export const Menu3 = () => {
    return (
        <div>
            <h1>MENU3</h1>
        </div>
    );
};

const ContentDiv = styled.div`
    padding: '8px';
    color: rgba(0, 200, 200, 0.7);
`;
