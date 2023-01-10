import React, { Component } from 'react';

class Ex01 extends Component {
    render() {
        const message = this.props.test ? "메시지나옴":"메시지안나옴";
        return (
            <div>
                {message}
            </div>
        );
    }
}

export default Ex01;