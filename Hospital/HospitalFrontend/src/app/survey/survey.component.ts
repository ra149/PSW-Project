import { Component } from "@angular/core";
import {NgbRatingConfig} from '@ng-bootstrap/ng-bootstrap';

@Component({
    selector: 'app-survey',
    templateUrl: './survey.component.html',
    styleUrls: ['./survey.component.css'],
    providers: [NgbRatingConfig]
})
export class SurveyComponent {
    constructor(config: NgbRatingConfig) {
        // customize default values of ratings used by this component tree
        config.max = 5;
      }
    currentRate1 = 3;
    currentRate2 = 3;
    currentRate3 = 3;
    currentRate4 = 3;
    currentRate5 = 3;
    currentRate6 = 3;
    currentRate7 = 3;
    currentRate8 = 3;
    currentRate9 = 3;
    currentRate10 = 3;
    currentRate11 = 3;
    currentRate12 = 3;
    currentRate13 = 3;
    currentRate14 = 3;
    currentRate15 = 3;
}