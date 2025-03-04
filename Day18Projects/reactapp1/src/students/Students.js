import React from "react";

class Students extends React.Component {

    render()
    {
        return (
                <div className="container p-4">
                    <div className="row">
                        Students Enrolled
                    </div>
                    <div className="row border">
                        <div className="col-2">
                            <img src={this.props.headspot} className="w-100" alt="student" />
                        </div>
                        <div className="col-8">
                            {this.props.fullName}<br />
                            Programming Experience {this.props.programmingExp} years
                        </div>
                        <div className="col-2">
                            {this.props.children}
                        </div>
                    </div>
                </div>
            );
    }

    
}

export  default Students