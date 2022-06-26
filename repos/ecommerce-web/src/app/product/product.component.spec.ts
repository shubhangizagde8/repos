import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProduvtComponent } from './product.component';

describe('ProductComponent', () => {
  let component: ProduvtComponent;
  let fixture: ComponentFixture<ProduvtComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProduvtComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProduvtComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
