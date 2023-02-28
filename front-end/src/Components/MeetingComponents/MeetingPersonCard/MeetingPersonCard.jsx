import React from 'react'
import "./MeetingPersonCard.css"
import RadiusImg from "../../RadiusImg/RadiusImg";


function MeetingPersonCard(props) {
  return (
    <div className='meetingPersonCard'>
      <RadiusImg size="100px" img={props.img} />
      <h4>{props.name}</h4>
    </div>
  );
}

export default MeetingPersonCard