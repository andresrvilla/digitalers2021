import React from 'react';
import Item from '../item/item.component'

class Lista extends React.Component {

    render() {
        return <>
            {
                this.props.items
                    .filter(i => this.props.filtro == "" || i.valor.toUpperCase().includes(this.props.filtro.toUpperCase()))
                    .map(i =>
                        <Item key={i.valor} valor={i.valor} comprado={i.comprado} onQuitar={this.props.onQuitar} />
                    )
            }
        </>
    }
}

export default Lista;