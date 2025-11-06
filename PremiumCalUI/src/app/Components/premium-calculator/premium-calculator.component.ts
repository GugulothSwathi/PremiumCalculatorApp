import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { PremiumService } from '../../Services/premium.service';
import { CommonModule, DecimalPipe } from '@angular/common';

@Component({
  selector: 'app-premium-calculator',
  imports: [ CommonModule,DecimalPipe,ReactiveFormsModule],
  templateUrl: './premium-calculator.component.html',
  styleUrl: './premium-calculator.component.less',
})
export class PremiumCalculatorComponent implements OnInit {

form: FormGroup;
occupations = [
'Cleaner', 'Doctor', 'Author', 'Farmer', 'Mechanic', 'Florist', 'Other'
];
result: any = null;
loading = false;
error: string | null = null;


constructor(private fb: FormBuilder, private service: PremiumService) {
this.form = this.fb.group({
name: ['', Validators.required],
ageNextBirthday: [null, [Validators.required, Validators.min(0), Validators.max(150)]],
dateOfBirth: ['', Validators.required],
occupation: ['', Validators.required],
deathSumInsured: [null, [Validators.required, Validators.min(0.01)]]
});
}


ngOnInit(): void {
// When occupation changes, trigger calculation if all fields valid
this.form.get('occupation')!.valueChanges.subscribe(() => {
this.tryCalculate();
});
}


tryCalculate() {
this.error = null;
if (this.form.valid) {
this.calculate();
}
}


calculate() {
this.loading = true;
const payload = {
name: this.form.value.name,
ageNextBirthday: Number(this.form.value.ageNextBirthday),
dateOfBirth: this.form.value.dateOfBirth,
occupation: this.form.value.occupation,
deathSumInsured: Number(this.form.value.deathSumInsured)
};


this.service.calculate(payload).subscribe({
next: res => {
this.result = res;
this.loading = false;
},
error: err => {
this.error = 'Failed to calculate premium. Check backend is running and CORS.';
this.loading = false;
}
});
}
}
