import IndexTasks from "./challenges/IndexTasks";
import SubmitTask from "./challenges/SubmitTask";
import LandingPage from "./LandingPage";
import RedirectToLandingPage from "./utils/RedirectToLandingPage";

const routes = [
{path: '/challenges', component: IndexTasks, exact: true},
{path: '/challenges/submitTask', component: SubmitTask},
{path: '/', component: LandingPage, exact: true},
{path: '*', component: RedirectToLandingPage}
];
export default routes;