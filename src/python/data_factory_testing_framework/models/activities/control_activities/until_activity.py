from typing import Callable, Generator

from data_factory_testing_framework.generated.models import ForEachActivity, Activity, ControlActivity, \
    UntilActivity
from data_factory_testing_framework.models.state.pipeline_run_state import PipelineRunState


class UntilActivity:

    def evaluate(self: UntilActivity, state: PipelineRunState):
        self.expression.evaluate(state)

        return super(ControlActivity, self).evaluate(state)

    def evaluate_control_activity_iterations(self: UntilActivity, state: PipelineRunState, evaluate_activities: Callable[[PipelineRunState], Generator[Activity, None, None]]):
        while True:
            scoped_state = state.create_iteration_scope(None)
            for activity in evaluate_activities(self.activities, scoped_state):
                yield activity

            state.add_scoped_activity_results_from_scoped_state(scoped_state)

            if self.expression.evaluate(state):
                break