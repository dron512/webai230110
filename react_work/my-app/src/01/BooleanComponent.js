import React, { Component } from 'react';
import PropTypes from 'prop-types'

/*
프로퍼티에서는 자바스크립트의 자료형을 모두 사용할 수 있습니다. 이때 프로퍼티의 자료형은 미리 선언해주는것이
좋습니다. 프로퍼티의 자료형을 미리 선언하면 리액트 엔진이 프로퍼티로 전달하는 값의 변화를 효율적으로
감지할 수 있고, 개발자가 실수로 지정되지 않은 자료형을 프로퍼티에 전달하고 할때 경고
*/
class BooleanComponent extends Component {
    render() {
        const message = this.props.boolValue? '놀러가자':'하던일 마무리 하자';
        return (
            <div>
                <h1 className='title'>{message}</h1>
                {this.props.name+1}<br/>
                {this.props.boolValue+10}<br/>
                {this.props.numValue}<br/>
                {this.props.objValue.test}<br/>
            </div>
        );
    }
}

BooleanComponent.propTypes = {
    name: PropTypes.string,
    boolValue : PropTypes.bool,
    numValue : PropTypes.number,
    objValue : PropTypes.object
}

export default BooleanComponent;
