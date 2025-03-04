import React from "react";
class StudentReview extends React.Component
{
    render() {
        return (
            <div className="p-2">
            <i class="bi bi-hand-thumbs-up-fill text-success"></i> &nsbp;
            <i class="bi bi-hand-thumbs-down-fill text-danger"></i>
            </div>
            );
    }

}


export {StudentReview}