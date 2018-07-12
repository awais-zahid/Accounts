import React, {Component} from 'react';
import $ from 'jquery';

export class TitlePage extends Component {
    constructor(){
        super();
        this.state={
            pagetitle:"",
            author:""
        }
    }

    componentDidMount() {
        this.GetTitleandAuthorName();
    }

    GetTitleandAuthorName() {
        var states = this;
        $.ajax({
            url: 'http://localhost:8080/api/titlepage',
            type: 'GET',
            
            success: function (response) {
                console.log("AlhamduLillah Got Data from Server");
                states.setState({ 
                    pagetitle: response[0].pageTitle, 
                    author:response[0].author
                });    
            },
            error: function () {
                console.clear();
                console.log("SERVER ERROR");          
            }
        });
    }
    render(){
        return (
            <div>
                <h1 className="App-title" style={{ display: 'inline-block' }}>{this.state.pagetitle}</h1>
                <h6 style={{ display: 'inline-block' }}>by {this.state.author} </h6>
            </div>
        );
    }
}
export default TitlePage