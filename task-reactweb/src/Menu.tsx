import axios from "axios";
import { NavLink, useHistory } from "react-router-dom";
import Solve from "./challenges/Solve";
import { rootObjectCard } from "./challenges/Solve.model";
import { urlChallenges } from "./endpoints";

export default function Menu() {

    const history = useHistory();
    async function create(task: rootObjectCard){
        try{
            await axios.post(urlChallenges, task)
            history.push('/challenges');
        }
        catch (error) {
            console.error(error);
        }
    }

    return (
        <nav className="navbar navbar-expand-lg navbar-light bg-light">
            <div className="container-fluid">
                <NavLink className="navbar-brand" to="/">Cognizant Challenge</NavLink>
                <div className="collapse navbar-collapse">
                    <ul className="navbar-nav me-auto mb-2 mb-lg-0">
                        <li className="nav-item">
                            <NavLink className="nav-link" to="/challenges">
                                Submited Challenges
                            </NavLink>
                        </li>
                    </ul>
                    <ul>
                        <div className="container mr-2">
                            <Solve model={{                                
                                clientId: '',
                                clientSecret: '',
                                script: '',
                                stdin: '',
                                language: '',
                                versionIndex: '',
                            }}
                            onSubmit={async value => {await create(value);}}
                            >SOLVE</Solve>
                        </div>
                    </ul>
                </div>
            </div>
        </nav>
    )
}
