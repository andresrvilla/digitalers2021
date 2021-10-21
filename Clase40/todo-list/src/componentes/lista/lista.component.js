import React from 'react';

class Lista extends React.Component {
    render() {
        return <ul>{ this.props.children }</ul>
    }
}

export default Lista;