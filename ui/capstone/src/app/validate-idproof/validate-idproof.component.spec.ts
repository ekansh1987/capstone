import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ValidateIdproofComponent } from './validate-idproof.component';

describe('ValidateIdproofComponent', () => {
  let component: ValidateIdproofComponent;
  let fixture: ComponentFixture<ValidateIdproofComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ValidateIdproofComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ValidateIdproofComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
